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
    [Register ("BmiViewController")]
    partial class BmiViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton backButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bmiResult { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel textLable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (backButton != null) {
                backButton.Dispose ();
                backButton = null;
            }

            if (bmiResult != null) {
                bmiResult.Dispose ();
                bmiResult = null;
            }

            if (textLable != null) {
                textLable.Dispose ();
                textLable = null;
            }
        }
    }
}