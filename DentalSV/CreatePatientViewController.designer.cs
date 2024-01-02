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
	[Register ("CreatePatientViewController")]
	
	partial class CreatePatientViewController
	{
		[Outlet]
		AppKit.NSTextField AllergiesTxtField { get; set; }

		[Outlet]
		AppKit.NSDatePicker BirthDateDatePicker { get; set; }

		[Outlet]
		AppKit.NSTextField ChronicDiseasesTxtField { get; set; }

		[Outlet]
		AppKit.NSImageView ImgViewField { get; set; }

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
		AppKit.NSTextField ProstheticPlanTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField SurnameTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField VisualInspectionTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField WorkingPlaceTxtField { get; set; }

		[Action ("BackBtn:")]
		partial void BackBtn (Foundation.NSObject sender);

		[Action ("DentalFormulaBtn:")]
		partial void DentalFormulaBtn (Foundation.NSObject sender);

		[Action ("SaveAndReceptionBtn:")]
		partial void SaveAndReceptionBtn (Foundation.NSObject sender);

		[Action ("SaveBtn:")]
		partial void SaveBtn (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (SurnameTxtField != null) {
				SurnameTxtField.Dispose ();
				SurnameTxtField = null;
			}

			if (NameTxtField != null) {
				NameTxtField.Dispose ();
				NameTxtField = null;
			}

			if (PatronymicTxtField != null) {
				PatronymicTxtField.Dispose ();
				PatronymicTxtField = null;
			}

			if (BirthDateDatePicker != null) {
				BirthDateDatePicker.Dispose ();
				BirthDateDatePicker = null;
			}

			if (PhoneTxtField != null) {
				PhoneTxtField.Dispose ();
				PhoneTxtField = null;
			}

			if (PensionerComboBox != null) {
				PensionerComboBox.Dispose ();
				PensionerComboBox = null;
			}

			if (WorkingPlaceTxtField != null) {
				WorkingPlaceTxtField.Dispose ();
				WorkingPlaceTxtField = null;
			}

			if (ChronicDiseasesTxtField != null) {
				ChronicDiseasesTxtField.Dispose ();
				ChronicDiseasesTxtField = null;
			}

			if (AllergiesTxtField != null) {
				AllergiesTxtField.Dispose ();
				AllergiesTxtField = null;
			}

			if (MucosalConditionTxtField != null) {
				MucosalConditionTxtField.Dispose ();
				MucosalConditionTxtField = null;
			}

			if (ProstheticPlanTxtField != null) {
				ProstheticPlanTxtField.Dispose ();
				ProstheticPlanTxtField = null;
			}

			if (InjurysTxtField != null) {
				InjurysTxtField.Dispose ();
				InjurysTxtField = null;
			}

			if (InfectiousDiseasesTxtField != null) {
				InfectiousDiseasesTxtField.Dispose ();
				InfectiousDiseasesTxtField = null;
			}

			if (VisualInspectionTxtField != null) {
				VisualInspectionTxtField.Dispose ();
				VisualInspectionTxtField = null;
			}

			if (ImgViewField != null) {
				ImgViewField.Dispose ();
				ImgViewField = null;
			}
		}
	}
}
