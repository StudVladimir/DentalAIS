using System;
using AppKit;
using CoreGraphics;

namespace DentalSV
{
	public class VisitTableDelegate : NSTableViewDelegate
    {
        #region Constants 
        private const string CellIdentifier = "";
        #endregion

        #region Private Variables
        private VisitTableDataSource DataSource;
        public MedCardViewController Controller;
        #endregion

        #region Constructors
        public VisitTableDelegate(MedCardViewController controller, VisitTableDataSource datasource)
        {
            this.Controller = controller;
            this.DataSource = datasource;
        }
        #endregion

        #region Override Methods
        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            // This pattern allows you reuse existing views when they are no-longer in use.
            // If the returned view is null, you instance up a new view
            // If a non-null view is returned, you modify it enough to reflect the new data
            NSTableCellView view = (NSTableCellView)tableView.MakeView(tableColumn.Title, this);
            if (view == null)
            {
                view = new NSTableCellView();

                // Configure the view
                view.Identifier = tableColumn.Title;

                // Take action based on title
                switch (tableColumn.Title)
                {
                    case "Дата":
                        view.TextField = new NSTextField(new CGRect(0, 3, 400, 16));
                        ConfigureTextField(view, row);
                        break;
                    case "Процедура":
                        view.TextField = new NSTextField(new CGRect(0, 3, 400, 16));
                        ConfigureTextField(view, row);
                        break;
                    case "Мед Карта":
                        // Create new button
                        var button = new NSButton(new CGRect(0, 3, 81, 16));
                        button.SetButtonType(NSButtonType.MomentaryPushIn);
                        button.Title = "Мед карта";
                        button.Tag = row;

                        // Wireup events
                        button.Activated += (sender, e) => {
                            // Get button and patient
                            var btn = sender as NSButton;
                            var visit = DataSource.VisitS[(int)btn.Tag];
                        };

                        // Add to view
                        view.AddSubview(button);
                        break;
                }

            }

            // Setup view based on the column selected
            switch (tableColumn.Title)
            {
                case "Дата":
                    view.TextField.StringValue = DataSource.VisitS[(int)row].VisitDateTime;
                    view.TextField.Tag = row;
                    break;
                case "Процедура":
                    view.TextField.StringValue = DataSource.VisitS[(int)row].Discription;
                    view.TextField.Tag = row;
                    break;
                case "Мед Карта":
                    foreach (NSView subview in view.Subviews)
                    {
                        var btn = subview as NSButton;
                        if (btn != null)
                        {
                            btn.Tag = row;
                        }
                    }
                    break;
            }
            return view;
        }
        #endregion


        //Поиск строки
        public override nint GetNextTypeSelectMatch(NSTableView tableView, nint startRow, nint endRow, string searchString)
        {
            nint row = 0;
            foreach (Visit visit in DataSource.VisitS)
            {
                if (visit.VisitDateTime.Contains(searchString)) return row;

                // Increment row counter
                ++row;
            }
            // If not found select the first row
            return 0;
        }



        public override bool ShouldSelectRow(NSTableView tableView, nint row)
        {
            //Метод для выборки столбцов
            return true;
        }



        public override bool ShouldReorder(NSTableView tableView, nint columnIndex, nint newColumnIndex)
        {
            //Метод для перестановки столбцов местами
            return true;
        }



        private void ConfigureTextField(NSTableCellView view, nint row)
        {
            // Add to view
            view.TextField.AutoresizingMask = NSViewResizingMask.WidthSizable;
            view.AddSubview(view.TextField);

            // Configure
            view.TextField.BackgroundColor = NSColor.Clear;
            view.TextField.Bordered = false;
            view.TextField.Selectable = false;
            view.TextField.Editable = true;

            // Wireup events
            view.TextField.EditingEnded += (sender, e) => {

                // Take action based on type
                switch (view.Identifier)
                {
                    case "Дата":
                        DataSource.VisitS[(int)view.TextField.Tag].VisitDateTime = view.TextField.StringValue;
                        break;
                    case "Процедура":
                        DataSource.VisitS[(int)view.TextField.Tag].Discription = view.TextField.StringValue;
                        break;
                }
            };
            // Tag view
            view.TextField.Tag = row;
        }
    }
}