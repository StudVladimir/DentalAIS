using System;
using AppKit;

namespace DentalSV
{
	public class PatRotezesTableDelegate : NSTableViewDelegate
    {
        #region Constants 
        private const string CellIdentifier = "";
        #endregion

        #region Private Variables
        private PatRotezesTableDataSourse DataSource;
        #endregion

        #region Constructors
        public PatRotezesTableDelegate(PatRotezesTableDataSourse datasource)
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
            NSTextField view = (NSTextField)tableView.MakeView(tableColumn.Title, this);
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
                case "ID":
                    view.IntValue = DataSource.ProtezesS[(int)row].Protez_ID;
                    break;
                case "Материал":
                    view.StringValue = DataSource.ProtezesS[(int)row].Materials;
                    break;
                case "Размер":
                    view.StringValue = DataSource.ProtezesS[(int)row].Size;
                    break;
                case "Гарнитур":
                    view.StringValue = DataSource.ProtezesS[(int)row].DentalSet;
                    break;
                case "Кламмера":
                    view.StringValue = DataSource.ProtezesS[(int)row].Clammers;
                    break;
                case "Сёдла":
                    view.IntValue = DataSource.ProtezesS[(int)row].Saddles;
                    break;
                case "Кол-во кламмеров":
                    view.IntValue = DataSource.ProtezesS[(int)row].ClammersQuantity;
                    break;
            }
            return view;
        }
        #endregion
    }
}

