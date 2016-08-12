// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace caculateBmi
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ageNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton caculateButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField heightNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton resetButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField weightNum { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ageNum != null) {
                ageNum.Dispose ();
                ageNum = null;
            }

            if (caculateButton != null) {
                caculateButton.Dispose ();
                caculateButton = null;
            }

            if (heightNum != null) {
                heightNum.Dispose ();
                heightNum = null;
            }

            if (resetButton != null) {
                resetButton.Dispose ();
                resetButton = null;
            }

            if (weightNum != null) {
                weightNum.Dispose ();
                weightNum = null;
            }
        }
    }
}