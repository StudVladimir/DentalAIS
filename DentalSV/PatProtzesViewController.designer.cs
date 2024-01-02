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
	[Register ("PatProtzesViewController")]
	partial class PatProtzesViewController
	{
		[Outlet]
		AppKit.NSTableColumn ClammersColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn ClammersQuantityColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn DentalSetColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn IdColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn MaterialColumn { get; set; }

		[Outlet]
		AppKit.NSTableView ProtezisTableView { get; set; }

		[Outlet]
		AppKit.NSTableColumn SaddlesColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn SizeColumn { get; set; }

		[Action ("AddProtez:")]
		partial void AddProtez (Foundation.NSObject sender);

		[Action ("BtnBack:")]
		partial void BtnBack (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (IdColumn != null) {
				IdColumn.Dispose ();
				IdColumn = null;
			}

			if (ProtezisTableView != null) {
				ProtezisTableView.Dispose ();
				ProtezisTableView = null;
			}

			if (MaterialColumn != null) {
				MaterialColumn.Dispose ();
				MaterialColumn = null;
			}

			if (SizeColumn != null) {
				SizeColumn.Dispose ();
				SizeColumn = null;
			}

			if (DentalSetColumn != null) {
				DentalSetColumn.Dispose ();
				DentalSetColumn = null;
			}

			if (ClammersColumn != null) {
				ClammersColumn.Dispose ();
				ClammersColumn = null;
			}

			if (SaddlesColumn != null) {
				SaddlesColumn.Dispose ();
				SaddlesColumn = null;
			}

			if (ClammersQuantityColumn != null) {
				ClammersQuantityColumn.Dispose ();
				ClammersQuantityColumn = null;
			}
		}
	}
}
