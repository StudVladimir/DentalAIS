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
	[Register ("LoginFailViewController")]
	partial class LoginFailViewController
	{
		[Outlet]
		AppKit.NSTextField FailLabel { get; set; }

		[Action ("BtnBack:")]
		partial void BtnBack (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (FailLabel != null) {
				FailLabel.Dispose ();
				FailLabel = null;
			}
		}
	}
}
