using System;
using AppKit;

namespace DentalSV
{
	public class ReceptionTableDelegate : NSTableViewDelegate
    {
        #region Constants 
        private const string CellIdentifier = "";
        #endregion

        #region Private Variables
        private ReceptionTableDataSource DataSource;
        #endregion

        #region Constructors
        public ReceptionTableDelegate(ReceptionTableDataSource datasource)
        {
            this.DataSource = datasource;
        }
        #endregion

        #region Override Methods
        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            // This pattern allows you reuse existing views when they are no-longer in use.
            // If the returned view is null, you instance up a new view
            // If a non-null view is returned, you modify it enough to reflect the new data
            NSTextField view = (NSTextField)tableView.MakeView (tableColumn.Title, this);
            if (view == null)
            {
                view = new NSTextField();
                view.Identifier = CellIdentifier;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
            }

            // Setup view based on the column selected
            switch (tableColumn.Title)
            {
                case "Дата / Время":
                    view.StringValue = DataSource.ReceptionS[(int)row].DateTime;
                    break;
                case "Кабинет":
                    view.IntValue = DataSource.ReceptionS[(int)row].Cabinet_id;
                    break;
                case "Пациент":
                    view.StringValue = DataSource.ReceptionS[(int)row].Patient_id;
                    break;
                case "Описание":
                    view.StringValue = DataSource.ReceptionS[(int)row].Discription;
                    break;
            }


            return view;
        }
        #endregion
    }
}

