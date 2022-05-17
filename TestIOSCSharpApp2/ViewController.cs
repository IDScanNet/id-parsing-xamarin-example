using Foundation;
using System;
using UIKit;

namespace TestIOSCSharpApp2
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ButtonParse.TouchUpInside += (object sender, EventArgs e) =>
            {
                Parser parser = new Parser();
                TextParseResult.Text = parser.ParseTrackstring("@\n\rANSI 636055030002DL00410232ZG02730106DLDCAB\nDCBU2P\nDCDN\nDBA03022014\nDCSSANDERS\nDCTJEFF\nDBD03022010\nDBB11111971\nDBC1\nDAYBLU\nDAU105 in\nDAG42 WINE CELLAR CIR\nDAIDALTON\nDAJGA\nDAK876850000  \nDAQ000000109\nDCF0000000000000000000000109\nDCGUSA\nDCHB   \nDCE4\nDCK0000000000010901\r\nZGZGAN\nZGBRev06222009\nZGCY\nZGDN\nZGEN\nZGFN\nZGG187\nZGH8-09\nZGI\nZGJN\nZGK00000000109\nZGL0000000000109\nZGM123\n\n");
            };
                // Perform any additional setup after loading the view, typically from a nib.
            }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
