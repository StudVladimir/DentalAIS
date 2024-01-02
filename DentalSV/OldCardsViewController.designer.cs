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
	[Register ("OldCardsViewController")]
	partial class OldCardsViewController
	{
		[Outlet]
		AppKit.NSTableColumn DateColumn { get; set; }

		[Outlet]
		AppKit.NSTextField LableDateUpdate { get; set; }

		[Outlet]
		AppKit.NSTableColumn MedCardColumn { get; set; }

		[Outlet]
		AppKit.NSTableView OldCardsTableView { get; set; }

		[Outlet]
		AppKit.NSTextField TxtFieldAllergies { get; set; }

		[Outlet]
		AppKit.NSTextField TxtFieldChronicalDiseases { get; set; }

		[Outlet]
		AppKit.NSTextField TxtFieldInfectionDiseases { get; set; }

		[Outlet]
		AppKit.NSTextField TxtFieldInjurys { get; set; }

		[Outlet]
		AppKit.NSTextField TxtFieldMucosalCondition { get; set; }

		[Outlet]
		AppKit.NSTextField TxtFieldProtethisPlan { get; set; }

		[Outlet]
		AppKit.NSTextField TxtFieldVisualInspection { get; set; }

		[Action ("BtnBack:")]
		partial void BtnBack (Foundation.NSObject sender);

		[Action ("BtnDelntalFormula:")]
		partial void BtnDelntalFormula (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (OldCardsTableView != null) {
				OldCardsTableView.Dispose ();
				OldCardsTableView = null;
			}

			if (DateColumn != null) {
				DateColumn.Dispose ();
				DateColumn = null;
			}

			if (MedCardColumn != null) {
				MedCardColumn.Dispose ();
				MedCardColumn = null;
			}

			if (TxtFieldChronicalDiseases != null) {
				TxtFieldChronicalDiseases.Dispose ();
				TxtFieldChronicalDiseases = null;
			}

			if (TxtFieldAllergies != null) {
				TxtFieldAllergies.Dispose ();
				TxtFieldAllergies = null;
			}

			if (TxtFieldMucosalCondition != null) {
				TxtFieldMucosalCondition.Dispose ();
				TxtFieldMucosalCondition = null;
			}

			if (TxtFieldProtethisPlan != null) {
				TxtFieldProtethisPlan.Dispose ();
				TxtFieldProtethisPlan = null;
			}

			if (TxtFieldInjurys != null) {
				TxtFieldInjurys.Dispose ();
				TxtFieldInjurys = null;
			}

			if (TxtFieldInfectionDiseases != null) {
				TxtFieldInfectionDiseases.Dispose ();
				TxtFieldInfectionDiseases = null;
			}

			if (TxtFieldVisualInspection != null) {
				TxtFieldVisualInspection.Dispose ();
				TxtFieldVisualInspection = null;
			}

			if (LableDateUpdate != null) {
				LableDateUpdate.Dispose ();
				LableDateUpdate = null;
			}
		}
	}
}
