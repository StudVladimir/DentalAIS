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
	[Register ("LogHistoryViewController")]
	partial class LogHistoryViewController
	{
		[Outlet]
		AppKit.NSTableColumn DateTimeColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn FIOColumn { get; set; }

		[Outlet]
		AppKit.NSTableColumn IdColumn { get; set; }

		[Outlet]
		AppKit.NSTableView LogHisTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LogHisTableView != null) {
				LogHisTableView.Dispose ();
				LogHisTableView = null;
			}

			if (IdColumn != null) {
				IdColumn.Dispose ();
				IdColumn = null;
			}

			if (FIOColumn != null) {
				FIOColumn.Dispose ();
				FIOColumn = null;
			}

			if (DateTimeColumn != null) {
				DateTimeColumn.Dispose ();
				DateTimeColumn = null;
			}
		}
	}
}
