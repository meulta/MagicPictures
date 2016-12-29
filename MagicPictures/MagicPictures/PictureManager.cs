using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Plugin;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace MagicPictures
{
	public class PictureManager
	{
		public PictureManager()
		{
		}

		public async Task<MediaFile> TakePicture(int compression = 50)
		{
			MediaFile image = null;

			if (CrossMedia.Current.IsCameraAvailable)
			{
				var cameraOptions = new StoreCameraMediaOptions();
				cameraOptions.CompressionQuality = compression;
				image = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(cameraOptions);				      
			}

			return image;
		}

		public async Task<string> GetImageCaption(MediaFile image)
		{
			var visionApi = new Services.MicrosoftCognitiveCaptionService();
			return await visionApi.GetCaptionAsync(image.GetStream());
		}
	}
}
