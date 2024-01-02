// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DentalSV
{
	[Register ("CreateReceptionViewController")]
	partial class CreateReceptionViewController
	{
		[Outlet]
		AppKit.NSTextField BirthDateTxtField { get; set; }

		[Outlet]
		AppKit.NSButton BtnSaveReceptionOutlet { get; set; }

		[Outlet]
		AppKit.NSTableColumn CabinetColumn { get; set; }

		[Outlet]
		AppKit.NSComboBox CabinetComboBox { get; set; }

		[Outlet]
		AppKit.NSTextField ChoosenPatientIndicator { get; set; }

		[Outlet]
		AppKit.NSDatePicker DatePickerOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField DiscriptionTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField FIOTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField IDTxtField { get; set; }

		[Outlet]
		AppKit.NSTableColumn PatientColumn { get; set; }

		[Outlet]
		AppKit.NSTextField PhoneTxtField { get; set; }

		[Outlet]
		AppKit.NSTableColumn ProceduraColumn { get; set; }

		[Outlet]
		AppKit.NSTableView ReceptionTableView { get; set; }

		[Outlet]
		AppKit.NSLevelIndicator StarIndicator { get; set; }

		[Outlet]
		AppKit.NSTableColumn TimeColumn { get; set; }

		[Outlet]
		AppKit.NSDatePicker TimePickerDial { get; set; }

		[Outlet]
		AppKit.NSDatePicker TimePickerNumbers { get; set; }

		[Outlet]
		AppKit.NSLevelIndicator WorkLoad { get; set; }

		[Action ("BtnBack:")]
		partial void BtnBack (Foundation.NSObject sender);

		[Action ("BtnChoosePatient:")]
		partial void BtnChoosePatient (Foundation.NSObject sender);

		[Action ("BtnSaveReception:")]
		partial void BtnSaveReception (Foundation.NSObject sender);

		[Action ("CabinetComboBoxAction:")]
		partial void CabinetComboBoxAction (Foundation.NSObject sender);

		[Action ("ChoosePatient:")]
		partial void ChoosePatient (Foundation.NSObject sender);

		[Action ("DatePicker:")]
		partial void DatePicker (Foundation.NSObject sender);

		[Action ("FIOTxtFieldAction:")]
		partial void FIOTxtFieldAction (Foundation.NSObject sender);

		[Action ("TimePickerDialAction:")]
		partial void TimePickerDialAction (Foundation.NSObject sender);

		[Action ("TimePickerNumberAction:")]
		partial void TimePickerNumberAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (BirthDateTxtField != null) {
				BirthDateTxtField.Dispose ();
				BirthDateTxtField = null;
			}

			if (CabinetColumn != null) {
				CabinetColumn.Dispose ();
				CabinetColumn = null;
			}

			if (CabinetComboBox != null) {
				CabinetComboBox.Dispose ();
				CabinetComboBox = null;
			}

			if (ChoosenPatientIndicator != null) {
				ChoosenPatientIndicator.Dispose ();
				ChoosenPatientIndicator = null;
			}

			if (DatePickerOutlet != null) {
				DatePickerOutlet.Dispose ();
				DatePickerOutlet = null;
			}

			if (FIOTxtField != null) {
				FIOTxtField.Dispose ();
				FIOTxtField = null;
			}

			if (IDTxtField != null) {
				IDTxtField.Dispose ();
				IDTxtField = null;
			}

			if (PatientColumn != null) {
				PatientColumn.Dispose ();
				PatientColumn = null;
			}

			if (PhoneTxtField != null) {
				PhoneTxtField.Dispose ();
				PhoneTxtField = null;
			}

			if (ProceduraColumn != null) {
				ProceduraColumn.Dispose ();
				ProceduraColumn = null;
			}

			if (ReceptionTableView != null) {
				ReceptionTableView.Dispose ();
				ReceptionTableView = null;
			}

			if (StarIndicator != null) {
				StarIndicator.Dispose ();
				StarIndicator = null;
			}

			if (TimeColumn != null) {
				TimeColumn.Dispose ();
				TimeColumn = null;
			}

			if (TimePickerDial != null) {
				TimePickerDial.Dispose ();
				TimePickerDial = null;
			}

			if (TimePickerNumbers != null) {
				TimePickerNumbers.Dispose ();
				TimePickerNumbers = null;
			}

			if (WorkLoad != null) {
				WorkLoad.Dispose ();
				WorkLoad = null;
			}

			if (DiscriptionTxtField != null) {
				DiscriptionTxtField.Dispose ();
				DiscriptionTxtField = null;
			}

			if (BtnSaveReceptionOutlet != null) {
				BtnSaveReceptionOutlet.Dispose ();
				BtnSaveReceptionOutlet = null;
			}
		}
	}
}
