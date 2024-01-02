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
	[Register ("PatientsViewController")]
	partial class PatientsViewController
	{
		[Outlet]
		AppKit.NSTableColumn BirthdateColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn FIOColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn IdColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn MedCardColumn { get; set; }

		[Outlet]
		AppKit.NSTableView PatientsTable { get; set; }

		[Outlet]
		AppKit.NSTableColumn PensionerColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn PhoneColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn WorkingPlaceColumn { get; set; }

		[Action ("AddPatientBtn:")]
		partial void AddPatientBtn (Foundation.NSObject sender);

		[Action ("DeletePatientBtn:")]
		partial void DeletePatientBtn (Foundation.NSObject sender);

		[Action ("MedCardBtn:")]
		partial void MedCardBtn (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (BirthdateColumn != null) {
				BirthdateColumn.Dispose ();
				BirthdateColumn = null;
			}

			if (FIOColumn != null) {
				FIOColumn.Dispose ();
				FIOColumn = null;
			}

			if (IdColumn != null) {
				IdColumn.Dispose ();
				IdColumn = null;
			}

			if (MedCardColumn != null) {
				MedCardColumn.Dispose ();
				MedCardColumn = null;
			}

			if (PatientsTable != null) {
				PatientsTable.Dispose ();
				PatientsTable = null;
			}

			if (PensionerColumn != null) {
				PensionerColumn.Dispose ();
				PensionerColumn = null;
			}

			if (PhoneColumn != null) {
				PhoneColumn.Dispose ();
				PhoneColumn = null;
			}

			if (WorkingPlaceColumn != null) {
				WorkingPlaceColumn.Dispose ();
				WorkingPlaceColumn = null;
			}
		}
	}
}
