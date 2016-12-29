using Android.App;
using Android.Widget;
using Android.OS;
using MagicPictures.Services;
using Android.Net;
using Android.Graphics;

namespace MagicPictures.Droid
{
	[Activity(Label = "MagicPictures", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		PictureManager pm = new PictureManager();
		
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			Typeface font = Typeface.CreateFromAsset(this.Assets, "fontawesome-webfont.ttf");
			
			// Get our button from the layout resource,
			// and attach an event to it
			var button = FindViewById<Button>(Resource.Id.myButton);
			button.Click += Button_Click;
			button.Typeface = font;

			var buttonAbout = FindViewById<Button>(Resource.Id.buttonAbout);
			buttonAbout.Click += ButtonAbout_Click;

		}

		async void Button_Click(object sender, System.EventArgs e)
		{
			var image = await pm.TakePicture();
			FindViewById<ImageView>(Resource.Id.resultImage).SetImageURI(Uri.Parse(image.Path));
			var labelResult = FindViewById<TextView>(Resource.Id.LabelResult);
			labelResult.Text = "Thinking...";
			var analyseResult = await pm.GetImageCaption(image);
			labelResult.Text = analyseResult;
		}

		void ButtonAbout_Click(object sender, System.EventArgs e)
		{
			StartActivity(typeof(AboutActivity));
		}
	}
}

