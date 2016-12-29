// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace MagicPictures.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonAbout { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonTakePicture { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imagePhotoResult { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView labelCaption { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonAbout != null) {
                buttonAbout.Dispose ();
                buttonAbout = null;
            }

            if (ButtonTakePicture != null) {
                ButtonTakePicture.Dispose ();
                ButtonTakePicture = null;
            }

            if (imagePhotoResult != null) {
                imagePhotoResult.Dispose ();
                imagePhotoResult = null;
            }

            if (labelCaption != null) {
                labelCaption.Dispose ();
                labelCaption = null;
            }
        }
    }
}