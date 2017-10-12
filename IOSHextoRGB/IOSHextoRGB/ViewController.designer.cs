// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace IOSHextoRGB
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BlueValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ConvertButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel GreenValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField HexTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HexValueTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel RedValue { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BlueValue != null) {
                BlueValue.Dispose ();
                BlueValue = null;
            }

            if (ConvertButton != null) {
                ConvertButton.Dispose ();
                ConvertButton = null;
            }

            if (GreenValue != null) {
                GreenValue.Dispose ();
                GreenValue = null;
            }

            if (HexTextField != null) {
                HexTextField.Dispose ();
                HexTextField = null;
            }

            if (HexValueTitle != null) {
                HexValueTitle.Dispose ();
                HexValueTitle = null;
            }

            if (RedValue != null) {
                RedValue.Dispose ();
                RedValue = null;
            }
        }
    }
}