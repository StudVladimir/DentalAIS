using System;
using AppKit;
using CoreGraphics;

namespace DentalSV
{
    public class LogHistoryTableDelegate : NSTableViewDelegate
    {

        #region Constants 
        private const string CellIdentifier = "";
        #endregion

        #region Private Variables
        private LogHistoryTableDatasource DataSource;
        #endregion

        #region Constructors
        public LogHistoryTableDelegate(LogHistoryTableDatasource datasource)
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
                    view.IntValue = DataSource.LogHisS[(int)row].Log_ID;
                    break;
                case "ФИО":
                    view.StringValue = DataSource.LogHisS[(int)row].FIO;
                    break;
                case "Дата / время":
                    view.StringValue = DataSource.LogHisS[(int)row].DateTime;
                    break;
            }
            return view;
        }
        #endregion
    }
}

