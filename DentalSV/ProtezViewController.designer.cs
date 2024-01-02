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
	[Register ("ProtezViewController")]
	partial class ProtezViewController
	{
		[Outlet]
		AppKit.NSTextField BirthDateTxtField { get; set; }

		[Outlet]
		AppKit.NSButton BtnSaveOutlet { get; set; }

		[Outlet]
		AppKit.NSComboBox CBClammers { get; set; }

		[Outlet]
		AppKit.NSComboBox CBDentalSet { get; set; }

		[Outlet]
		AppKit.NSComboBox CBInset { get; set; }

		[Outlet]
		AppKit.NSComboBox CBMaterialsCrown { get; set; }

		[Outlet]
		AppKit.NSComboBox CBMaterialsFacetka { get; set; }

		[Outlet]
		AppKit.NSComboBox CBMaterialsFIRST { get; set; }

		[Outlet]
		AppKit.NSComboBox CBMaterialsLitok { get; set; }

		[Outlet]
		AppKit.NSComboBox CBProtezType { get; set; }

		[Outlet]
		AppKit.NSComboBox CBSaddles { get; set; }

		[Outlet]
		AppKit.NSComboBox CBSize { get; set; }

		[Outlet]
		AppKit.NSComboBox CBSolderingFacetka { get; set; }

		[Outlet]
		AppKit.NSComboBox CBSolderingLitok { get; set; }

		[Outlet]
		AppKit.NSTextField ChoosenPatientIndicator { get; set; }

		[Outlet]
		AppKit.NSTextField FIOTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField IDTxtField { get; set; }

		[Outlet]
		AppKit.NSTextField PhoneTxtField { get; set; }

		[Outlet]
		AppKit.NSLevelIndicator StarIndicator { get; set; }

		[Action ("BtnBack:")]
		partial void BtnBack (Foundation.NSObject sender);

		[Action ("BtnChoosePat:")]
		partial void BtnChoosePat (Foundation.NSObject sender);

		[Action ("BtnSaveAction:")]
		partial void BtnSaveAction (Foundation.NSObject sender);

		[Action ("BtnSaveProtezAction:")]
		partial void BtnSaveProtezAction (Foundation.NSObject sender);

		[Action ("CBProtezTypeAction:")]
		partial void CBProtezTypeAction (Foundation.NSObject sender);

		[Action ("FIOTxtFieldAction:")]
		partial void FIOTxtFieldAction (Foundation.NSObject sender);

		[Action ("ProtezTypeAction:")]
		partial void ProtezTypeAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (BirthDateTxtField != null) {
				BirthDateTxtField.Dispose ();
				BirthDateTxtField = null;
			}

			if (CBClammers != null) {
				CBClammers.Dispose ();
				CBClammers = null;
			}

			if (CBDentalSet != null) {
				CBDentalSet.Dispose ();
				CBDentalSet = null;
			}

			if (CBInset != null) {
				CBInset.Dispose ();
				CBInset = null;
			}

			if (CBMaterialsCrown != null) {
				CBMaterialsCrown.Dispose ();
				CBMaterialsCrown = null;
			}

			if (CBMaterialsFacetka != null) {
				CBMaterialsFacetka.Dispose ();
				CBMaterialsFacetka = null;
			}

			if (CBMaterialsFIRST != null) {
				CBMaterialsFIRST.Dispose ();
				CBMaterialsFIRST = null;
			}

			if (CBMaterialsLitok != null) {
				CBMaterialsLitok.Dispose ();
				CBMaterialsLitok = null;
			}

			if (CBProtezType != null) {
				CBProtezType.Dispose ();
				CBProtezType = null;
			}

			if (CBSaddles != null) {
				CBSaddles.Dispose ();
				CBSaddles = null;
			}

			if (CBSize != null) {
				CBSize.Dispose ();
				CBSize = null;
			}

			if (CBSolderingFacetka != null) {
				CBSolderingFacetka.Dispose ();
				CBSolderingFacetka = null;
			}

			if (CBSolderingLitok != null) {
				CBSolderingLitok.Dispose ();
				CBSolderingLitok = null;
			}

			if (ChoosenPatientIndicator != null) {
				ChoosenPatientIndicator.Dispose ();
				ChoosenPatientIndicator = null;
			}

			if (FIOTxtField != null) {
				FIOTxtField.Dispose ();
				FIOTxtField = null;
			}

			if (IDTxtField != null) {
				IDTxtField.Dispose ();
				IDTxtField = null;
			}

			if (PhoneTxtField != null) {
				PhoneTxtField.Dispose ();
				PhoneTxtField = null;
			}

			if (StarIndicator != null) {
				StarIndicator.Dispose ();
				StarIndicator = null;
			}

			if (BtnSaveOutlet != null) {
				BtnSaveOutlet.Dispose ();
				BtnSaveOutlet = null;
			}
		}
	}
}
