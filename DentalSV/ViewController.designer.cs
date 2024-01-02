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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField LoginTxtField { get; set; }

		[Outlet]
		AppKit.NSSecureTextField PasswordTxtField { get; set; }

		[Action ("EnterBtn:")]
		partial void EnterBtn (Foundation.NSObject sender);

		[Action ("RememberMeBtn:")]
		partial void RememberMeBtn (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (LoginTxtField != null) {
				LoginTxtField.Dispose ();
				LoginTxtField = null;
			}

			if (PasswordTxtField != null) {
				PasswordTxtField.Dispose ();
				PasswordTxtField = null;
			}
		}
	}
}
