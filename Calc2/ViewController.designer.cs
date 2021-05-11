// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Calc2
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField wText { get; set; }

		[Action ("ButtonClick:")]
		partial void ButtonClick (AppKit.NSButton sender);

		[Action ("ClearClick:")]
		partial void ClearClick (Foundation.NSObject sender);

		[Action ("EqualClick:")]
		partial void EqualClick (Foundation.NSObject sender);

		[Action ("OperationClick:")]
		partial void OperationClick (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (wText != null) {
				wText.Dispose ();
				wText = null;
			}
		}
	}
}
