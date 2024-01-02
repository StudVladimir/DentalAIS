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
	[Register ("ChoosePatForReceptViewController")]
	partial class ChoosePatForReceptViewController
	{
		[Outlet]
		AppKit.NSTableColumn BirthDateColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn FIOColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn IdColumn { get; set; }

		[Outlet]
		AppKit.NSTableView PatientsTableView { get; set; }

		[Outlet]
		AppKit.NSTableColumn PensionerColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn PhoneColumn { get; set; }

		[Outlet]
		AppKit.NSSearchField SearchFieldOutlet { get; set; }

		[Outlet]
		AppKit.NSTableColumn WorkingPlaceColumn { get; set; }

		[Action ("BtnCancel:")]
		partial void BtnCancel (Foundation.NSObject sender);

		[Action ("BtnChoosePatient:")]
		partial void BtnChoosePatient (Foundation.NSObject sender);

		[Action ("SearchFieldAction:")]
		partial void SearchFieldAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (SearchFieldOutlet != null) {
				SearchFieldOutlet.Dispose ();
				SearchFieldOutlet = null;
			}

			if (PatientsTableView != null) {
				PatientsTableView.Dispose ();
				PatientsTableView = null;
			}

			if (IdColumn != null) {
				IdColumn.Dispose ();
				IdColumn = null;
			}

			if (FIOColumn != null) {
				FIOColumn.Dispose ();
				FIOColumn = null;
			}

			if (BirthDateColumn != null) {
				BirthDateColumn.Dispose ();
				BirthDateColumn = null;
			}

			if (PhoneColumn != null) {
				PhoneColumn.Dispose ();
				PhoneColumn = null;
			}

			if (WorkingPlaceColumn != null) {
				WorkingPlaceColumn.Dispose ();
				WorkingPlaceColumn = null;
			}

			if (PensionerColumn != null) {
				PensionerColumn.Dispose ();
				PensionerColumn = null;
			}
		}
	}
}
