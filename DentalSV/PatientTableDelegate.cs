using System;
using System.Data;
using System.Windows.Input;
using AppKit;
using CoreGraphics;
using MySql.Data.MySqlClient;
using StoreKit;

namespace DentalSV
{
    public class PatientTableDelegate : NSTableViewDelegate
    {
        #region Constants 
        private const string CellIdentifier = "";
        #endregion

        #region Private Variables
        private PatientTableDataSource DataSource;
        public PatientsViewController Controller;
        public ChoosePatForReceptViewController Controller2;
        #endregion

        #region Constructors
        public PatientTableDelegate (PatientsViewController controller, PatientTableDataSource datasource)
        {
            this.Controller = controller;
            this.DataSource = datasource;
        }
        #endregion

        #region Constructors
        public PatientTableDelegate (ChoosePatForReceptViewController controller, PatientTableDataSource datasource)
        {
            this.Controller2 = controller;
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
                    case "Id":
                        view.ImageView = new NSImageView(new CGRect(0, 0, 16, 16));
                        view.AddSubview(view.ImageView);
                        view.TextField = new NSTextField(new CGRect(20, 0, 400, 16));
                        ConfigureTextField(view, row);
                        break;
                    case "ФИО":
                        view.TextField = new NSTextField(new CGRect(0, 0, 400, 16));
                        ConfigureTextField(view, row);
                        break;
                    case "Дата рождения":
                        view.TextField = new NSTextField(new CGRect(0, 0, 400, 16));
                        ConfigureTextField(view, row);
                        break;
                    case "Телефон":
                        view.TextField = new NSTextField(new CGRect(0, 0, 400, 16));
                        ConfigureTextField(view, row);
                        break;
                    case "Место работы":
                        view.TextField = new NSTextField(new CGRect(0, 0, 400, 16));
                        ConfigureTextField(view, row);
                        break;
                    case "Пенсионер":
                        view.TextField = new NSTextField(new CGRect(0, 0, 400, 16));
                        ConfigureTextField(view, row);
                        break;
                    case "Мед Карта":
                        // Create new button
                        var button = new NSButton(new CGRect(0, 0, 81, 16));
                        button.SetButtonType(NSButtonType.MomentaryPushIn);
                        button.Title = "Мед карта";
                        button.Tag = row;

                        // Wireup events
                        button.Activated += (sender, e) => {
                            // Get button and patient
                            var btn = sender as NSButton;
                            var patient = DataSource.PatientS[(int)btn.Tag];

                            PublicValues.ChoosenPatientID = patient.Id;
                            PatientsViewController.ClosePatientsWindow();
                            PatientsViewController controller = new PatientsViewController(PublicValues.handle);
                            controller.View.Window.OrderOut(Self);

                            var storyboard = NSStoryboard.FromName("Scene3", null);
                            var window = storyboard.InstantiateControllerWithIdentifier("MedicalCard") as NSWindowController;
                            window.ShowWindow(this);
                        };

                        // Add to view
                        view.AddSubview(button);
                        break;
                }
                
            }

            // Setup view based on the column selected
            switch (tableColumn.Title)
            {
                case "Id":
                    view.ImageView.Image = NSImage.ImageNamed("tag.png");
                    view.TextField.IntValue = DataSource.PatientS[(int)row].Id;
                    view.TextField.Tag = row;
                    break;
                case "ФИО":
                    view.TextField.StringValue = DataSource.PatientS[(int)row].FIO;
                    view.TextField.Tag = row;
                    break;
                case "Дата рождения":
                    view.TextField.StringValue = DataSource.PatientS[(int)row].BirthDate;
                    view.TextField.Tag = row;
                    break;
                case "Телефон":
                    view.TextField.StringValue = DataSource.PatientS[(int)row].Phone;
                    view.TextField.Tag = row;
                    break;
                case "Место работы":
                    view.TextField.StringValue = DataSource.PatientS[(int)row].WorkingPlace;
                    view.TextField.Tag = row;
                    break;
                case "Пенсионер":
                    view.TextField.StringValue = DataSource.PatientS[(int)row].Pensioner;
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



        public override nint GetNextTypeSelectMatch(NSTableView tableView, nint startRow, nint endRow, string searchString)
        {
            nint row = 0;
            foreach (Patient patient in DataSource.PatientS)
            {
                if (patient.FIO.Contains(searchString)) return row;

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
            view.TextField.Editable = false;

            // Wireup events
            view.TextField.EditingEnded += (sender, e) => {

                // Take action based on type
                switch (view.Identifier)
                {
                    case "Id":
                        DataSource.PatientS[(int)view.TextField.Tag].Id = view.TextField.IntValue;
                        break;
                    case "FIO":
                        DataSource.PatientS[(int)view.TextField.Tag].FIO = view.TextField.StringValue;
                        break;
                    case "Дата рождения":
                        DataSource.PatientS[(int)view.TextField.Tag].BirthDate = view.TextField.StringValue;
                        break;
                    case "Телефон":
                        DataSource.PatientS[(int)view.TextField.Tag].Phone = view.TextField.StringValue;
                        break;
                    case "Место работы":
                        DataSource.PatientS[(int)view.TextField.Tag].WorkingPlace = view.TextField.StringValue;
                        break;
                    case "Пенсионер":
                        DataSource.PatientS[(int)view.TextField.Tag].Pensioner = view.TextField.StringValue;
                        break;
                }
            };
            // Tag view
            view.TextField.Tag = row;
        }
    }
}