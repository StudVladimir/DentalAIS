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
	[Register ("ReceptionViewController")]
	partial class ReceptionViewController
	{
		[Outlet]
		AppKit.NSTableColumn CabinetColumn { get; set; }

		[Outlet]
		AppKit.NSDatePicker DatePicker { get; set; }

		[Outlet]
		AppKit.NSTableColumn DateTimeColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn DiscriptionColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn PatientColumn { get; set; }

		[Outlet]
		AppKit.NSTableView ReceptionTable { get; set; }

		[Outlet]
		AppKit.NSSearchField SearchField { get; set; }

		[Outlet]
		AppKit.NSLevelIndicator Workload { get; set; }

		[Action ("BtnCheck:")]
		partial void BtnCheck (Foundation.NSObject sender);

		[Action ("BtnDeleteReception:")]
		partial void BtnDeleteReception (Foundation.NSObject sender);

		[Action ("CreateNewReception:")]
		partial void CreateNewReception (Foundation.NSObject sender);

		[Action ("DatePickerAction:")]
		partial void DatePickerAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (CabinetColumn != null) {
				CabinetColumn.Dispose ();
				CabinetColumn = null;
			}

			if (DatePicker != null) {
				DatePicker.Dispose ();
				DatePicker = null;
			}

			if (DateTimeColumn != null) {
				DateTimeColumn.Dispose ();
				DateTimeColumn = null;
			}

			if (DiscriptionColumn != null) {
				DiscriptionColumn.Dispose ();
				DiscriptionColumn = null;
			}

			if (PatientColumn != null) {
				PatientColumn.Dispose ();
				PatientColumn = null;
			}

			if (ReceptionTable != null) {
				ReceptionTable.Dispose ();
				ReceptionTable = null;
			}

			if (SearchField != null) {
				SearchField.Dispose ();
				SearchField = null;
			}

			if (Workload != null) {
				Workload.Dispose ();
				Workload = null;
			}
		}
	}
}
