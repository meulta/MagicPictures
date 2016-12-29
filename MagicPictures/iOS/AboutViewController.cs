using System;
using Foundation;
using UIKit;

namespace MagicPictures.iOS
{
	public partial class AboutViewController : UIViewController
	{
		public AboutViewController(IntPtr handle) : base("AboutViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		[Action("UnwindToYellowViewController:")]
		public void UnwindToYellowViewController(UIStoryboardSegue segue)
		{
			Console.WriteLine("We've unwinded to Yellow!");
		}
	}
}

