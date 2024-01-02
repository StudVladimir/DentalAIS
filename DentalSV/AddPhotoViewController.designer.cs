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
	[Register ("AddPhotoViewController")]
	partial class AddPhotoViewController
	{
		[Outlet]
		AppKit.NSTextField BirthDateTxtField { get; set; }

		[Outlet]
		AppKit.NSButton BtnSavePhotoOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField ChoosenPatientIndicator { get; set; }

		[Outlet]
		AppKit.NSDatePicker DatePicker { get; set; }

		[Outlet]
		AppKit.NSTextField FIOTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField IDTxtField { get; set; }

		[Outlet]
		AppKit.NSImageView ImgView { get; set; }

		[Outlet]
		AppKit.NSTextField PhoneTxtField { get; set; }

		[Outlet]
		AppKit.NSLevelIndicator StarIndicator { get; set; }

		[Outlet]
		AppKit.NSTextField TxtFieldForPathOutlet { get; set; }

		[Action ("BtnBack:")]
		partial void BtnBack (Foundation.NSObject sender);

		[Action ("BtnChoosePat:")]
		partial void BtnChoosePat (Foundation.NSObject sender);

		[Action ("BtnSavePhotoAction:")]
		partial void BtnSavePhotoAction (Foundation.NSObject sender);

		[Action ("FIOTxtFieldAction:")]
		partial void FIOTxtFieldAction (Foundation.NSObject sender);

		[Action ("ImgViewAction:")]
		partial void ImgViewAction (Foundation.NSObject sender);

		[Action ("TxtFieldForPathAction:")]
		partial void TxtFieldForPathAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ImgView != null) {
				ImgView.Dispose ();
				ImgView = null;
			}

			if (TxtFieldForPathOutlet != null) {
				TxtFieldForPathOutlet.Dispose ();
				TxtFieldForPathOutlet = null;
			}

			if (FIOTxtField != null) {
				FIOTxtField.Dispose ();
				FIOTxtField = null;
			}

			if (IDTxtField != null) {
				IDTxtField.Dispose ();
				IDTxtField = null;
			}

			if (BtnSavePhotoOutlet != null) {
				BtnSavePhotoOutlet.Dispose ();
				BtnSavePhotoOutlet = null;
			}

			if (BirthDateTxtField != null) {
				BirthDateTxtField.Dispose ();
				BirthDateTxtField = null;
			}

			if (PhoneTxtField != null) {
				PhoneTxtField.Dispose ();
				PhoneTxtField = null;
			}

			if (StarIndicator != null) {
				StarIndicator.Dispose ();
				StarIndicator = null;
			}

			if (ChoosenPatientIndicator != null) {
				ChoosenPatientIndicator.Dispose ();
				ChoosenPatientIndicator = null;
			}

			if (DatePicker != null) {
				DatePicker.Dispose ();
				DatePicker = null;
			}
		}
	}
}
