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
	[Register ("MedCardViewController")]
	partial class MedCardViewController
	{
		[Outlet]
		AppKit.NSTextField AllergiesTxtField { get; set; }

		[Outlet]
		AppKit.NSDatePicker BirthdateDatePicker { get; set; }

		[Outlet]
		AppKit.NSButton BtnAllPhotosOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField ChronicDiseasesTxtField { get; set; }

		[Outlet]
		AppKit.NSTableColumn DateColumn { get; set; }

		[Outlet]
		AppKit.NSTextField DateUpdateCardLabel { get; set; }

		[Outlet]
		AppKit.NSTableColumn EarlyMedCardColumn { get; set; }

		[Outlet]
		AppKit.NSImageView ImgView { get; set; }

		[Outlet]
		AppKit.NSTextField InfectiousDiseasesTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField InjurysTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField MucosalConditionTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField NameTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField PatronymicTxtField { get; set; }

		[Outlet]
		AppKit.NSComboBox PensionerComboBox { get; set; }

		[Outlet]
		AppKit.NSTextField PhoneTxtField { get; set; }

		[Outlet]
		AppKit.NSTableColumn ProceduraColumn { get; set; }

		[Outlet]
		AppKit.NSTextField ProtheticPlanTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField SurnameTxtField { get; set; }

		[Outlet]
		AppKit.NSTableView VisitTableView { get; set; }

		[Outlet]
		AppKit.NSTextField VisualinspectionTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField WorkingPlaceTxtField { get; set; }

		[Action ("BtnAllPhotos:")]
		partial void BtnAllPhotos (Foundation.NSObject sender);

		[Action ("BtnBack:")]
		partial void BtnBack (Foundation.NSObject sender);

		[Action ("BtnCheckDentalFormula:")]
		partial void BtnCheckDentalFormula (Foundation.NSObject sender);

		[Action ("BtnCheckOtherMedCards:")]
		partial void BtnCheckOtherMedCards (Foundation.NSObject sender);

		[Action ("BtnProtezis:")]
		partial void BtnProtezis (Foundation.NSObject sender);

		[Action ("BtnSaveChanges:")]
		partial void BtnSaveChanges (Foundation.NSObject sender);

		[Action ("BtnVisitHistory:")]
		partial void BtnVisitHistory (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (AllergiesTxtField != null) {
				AllergiesTxtField.Dispose ();
				AllergiesTxtField = null;
			}

			if (BirthdateDatePicker != null) {
				BirthdateDatePicker.Dispose ();
				BirthdateDatePicker = null;
			}

			if (BtnAllPhotosOutlet != null) {
				BtnAllPhotosOutlet.Dispose ();
				BtnAllPhotosOutlet = null;
			}

			if (ChronicDiseasesTxtField != null) {
				ChronicDiseasesTxtField.Dispose ();
				ChronicDiseasesTxtField = null;
			}

			if (DateColumn != null) {
				DateColumn.Dispose ();
				DateColumn = null;
			}

			if (DateUpdateCardLabel != null) {
				DateUpdateCardLabel.Dispose ();
				DateUpdateCardLabel = null;
			}

			if (EarlyMedCardColumn != null) {
				EarlyMedCardColumn.Dispose ();
				EarlyMedCardColumn = null;
			}

			if (ImgView != null) {
				ImgView.Dispose ();
				ImgView = null;
			}

			if (InfectiousDiseasesTxtField != null) {
				InfectiousDiseasesTxtField.Dispose ();
				InfectiousDiseasesTxtField = null;
			}

			if (InjurysTxtField != null) {
				InjurysTxtField.Dispose ();
				InjurysTxtField = null;
			}

			if (MucosalConditionTxtField != null) {
				MucosalConditionTxtField.Dispose ();
				MucosalConditionTxtField = null;
			}

			if (NameTxtField != null) {
				NameTxtField.Dispose ();
				NameTxtField = null;
			}

			if (PatronymicTxtField != null) {
				PatronymicTxtField.Dispose ();
				PatronymicTxtField = null;
			}

			if (PensionerComboBox != null) {
				PensionerComboBox.Dispose ();
				PensionerComboBox = null;
			}

			if (PhoneTxtField != null) {
				PhoneTxtField.Dispose ();
				PhoneTxtField = null;
			}

			if (ProceduraColumn != null) {
				ProceduraColumn.Dispose ();
				ProceduraColumn = null;
			}

			if (ProtheticPlanTxtField != null) {
				ProtheticPlanTxtField.Dispose ();
				ProtheticPlanTxtField = null;
			}

			if (SurnameTxtField != null) {
				SurnameTxtField.Dispose ();
				SurnameTxtField = null;
			}

			if (VisitTableView != null) {
				VisitTableView.Dispose ();
				VisitTableView = null;
			}

			if (VisualinspectionTxtField != null) {
				VisualinspectionTxtField.Dispose ();
				VisualinspectionTxtField = null;
			}

			if (WorkingPlaceTxtField != null) {
				WorkingPlaceTxtField.Dispose ();
				WorkingPlaceTxtField = null;
			}
		}
	}
}
