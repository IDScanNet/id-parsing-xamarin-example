// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TestIOSCSharpApp2
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton ButtonParse { get; set; }

		[Outlet]
		UIKit.UITextView TextParseResult { get; set; }
			
		void ReleaseDesignerOutlets ()
		{
			if (TextParseResult != null) {
				TextParseResult.Dispose ();
				TextParseResult = null;
			}

			if (ButtonParse != null) {
				ButtonParse.Dispose ();
				ButtonParse = null;
			}
		}
	}
}
	