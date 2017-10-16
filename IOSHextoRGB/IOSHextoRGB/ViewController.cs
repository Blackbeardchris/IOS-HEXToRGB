using System;

using UIKit;

namespace IOSHextoRGB
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nig.
            convertButton.TouchUpInside += ConvertButton_TouchUpInside;
            //Event handler

        }
        void ConvertButton_TouchUpInside (object sender, EventArgs e)
        {
            string hexValue = hexValueTextField.Text;
            string redHexValue = hexValue.Substring(0, 2);
            string BlueHexValue = hexValue.Substring(4, 2);
            string GreenHexValue = hexValue.Substring(2, 2);
            //Cycles throgh the first two values of the hex string, to find the 1st and 3rd value of hex which correspondes with the RGB

            int redValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);
			int greenValue = int.Parse(GreenHexValue, System.Globalization.NumberStyles.HexNumber);
			int blueValue = int.Parse(BlueHexValue, System.Globalization.NumberStyles.HexNumber);

            redValueLabel.Text = redValue.ToString();
            greenValueLabel.Text = greenValue.ToString();
            blueValueLabel.Text = blueValue.ToString();

            colorView.BackgroundColor = UIColor.FromRGB(redValue, greenValue, blueValue);
		}


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
// variables: HexTextField, HexValueTitle, ConvertButton, GreenValue, BlueValue, RedValue
