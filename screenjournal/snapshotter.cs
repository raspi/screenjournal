using System;
using System.Reflection;
using System.IO;

namespace screenjournal
{
	public class settings
	{
		/// <summary>
		/// Save directory for screen shot images
		/// </summary>
		public string directory {get; set;}
	}

	public class snapshotter
	{
		public snapshotter ()
		{
		}

		protected settings getSettings()
		{
			//AppDomain.CurrentDomain.SetupInformation.ConfigurationFile = "settings.json";

			settings settings = new settings();

			settings.directory = Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures) + "\\" + Assembly.GetEntryAssembly().GetName().Name;

			return settings;
		}

		public void takeSnapShot()
		{
			var settings = getSettings();


			Gdk.Window window = Gdk.Global.DefaultRootWindow;

			if (window != null)
			{           
				Gdk.Pixbuf pixBuf = new Gdk.Pixbuf(Gdk.Colorspace.Rgb, false, 8, window.Screen.Width, window.Screen.Height);
				pixBuf.GetFromDrawable(window, Gdk.Colormap.System, 0, 0, 0, 0, window.Screen.Width, window.Screen.Height);

				var now = DateTime.Now;

				var dayPath = String.Format("{0:0000}-{1:00}-{2:00}", now.Year, now.Month, now.Day);
				var fileName = String.Format("{0:00}{1:00}{2:00},{3}", now.Hour, now.Minute, now.Second, now.Millisecond);

				var savePath = settings.directory + "\\" + dayPath;

				if(!Directory.Exists(savePath))
				{
					Directory.CreateDirectory(savePath);
				}

				savePath += "\\" + fileName + ".png";

				pixBuf.Save(savePath, "png");
			}

		}
	}
}

