using System;

using AppKit;
using Foundation;

namespace Calc2
{
    public partial class ViewController : NSViewController
    {
        public double first = 0;
        public double sum = 0;
        public string op = "";

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            wText.StringValue = "0";

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void ButtonClick(AppKit.NSButton sender)
        {
            if (wText.StringValue == "0" && sender.Title != ".")
            {
                wText.StringValue = "";
            }
            else if (wText.StringValue == "")
            {
                wText.StringValue = "0";
            }

            wText.StringValue += sender.Title;
            
        }

        partial void ClearClick(Foundation.NSObject sender)
        {
            first = 0;
            sum = 0;
            wText.StringValue = "0";
        }

        partial void EqualClick(Foundation.NSObject sender)
        {
            switch (op)
            {
                case "+":
                    sum = first + Convert.ToDouble(wText.StringValue);
                    break;
                case "-":
                    sum = first - Convert.ToDouble(wText.StringValue);
                    break;
                case "/":
                    sum = first / Convert.ToDouble(wText.StringValue);
                    break;
                case "*":
                    sum = first * Convert.ToDouble(wText.StringValue);
                    break;
                default:
                    break;
            }
            first = sum;
            wText.StringValue = Convert.ToString(sum);
        }

        partial void OperationClick(AppKit.NSButton sender)
        {
            first = Convert.ToDouble(wText.StringValue);
            wText.StringValue = "0";
            op = sender.Title;
        }
    }
}
