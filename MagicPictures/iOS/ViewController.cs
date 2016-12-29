using System;

using UIKit;

namespace MagicPictures.iOS
{
	public partial class ViewController : UIViewController
	{
		PictureManager pm;

		public ViewController(IntPtr handle) : base(handle)
		{
			pm = new PictureManager();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			ButtonTakePicture.TouchUpInside += this.ButtonTakePicture_TouchUpInside;

			// Code to start the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start ();
#endif

		}

		async void ButtonTakePicture_TouchUpInside(object sender, EventArgs e)
		{
			var picture = await pm.TakePicture();
			imagePhotoResult.Image = new UIImage(picture.Path);
			labelCaption.Text = "Thinking...";

			labelCaption.Text = await pm.GetImageCaption(picture);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
