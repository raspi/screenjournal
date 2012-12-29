using System;
using System.Reflection;
using System.IO;
using System.Timers;
using System.Collections.Specialized;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace screenjournal
{
	/// <summary>
	/// Settings for snapshotter
	/// </summary>
	public class settings
	{
		/// <summary>
		/// Save directory for screen shot images
		/// </summary>
		public string directory {get; set;}

		/// <summary>
		/// Screenshot taking interval in seconds
		/// </summary>
		public int interval {get; set;}
	}

	/// <summary>
	/// Main snapshotter class
	/// </summary>
	public class snapshotter
	{
		public settings settings;

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="screenjournal.snapshotter"/> is running.
		/// </summary>
		/// <value>
		/// <c>true</c> if is running; otherwise, <c>false</c>.
		/// </value>
		public bool isRunning 
		{
			get {return timer.Enabled;}
			set {return;}
		}

		protected Timer timer;

		protected string lastFileName = String.Empty;

		/// <summary>
		/// Constructor
		/// </summary>
		public snapshotter ()
		{
			settings = new settings();

			// Initialize timer
			timer = new System.Timers.Timer();
			timer.Enabled = false;
			timer.Elapsed += new ElapsedEventHandler(onTakeSnapShot);
		}

		public void runThread()
		{
			timer.Interval = settings.interval * 1000;
			timer.Enabled = true;

			takeSnapShot();
		}

		public void stopThread()
		{
			timer.Enabled = false;
		}

		public void onTakeSnapShot(object source, ElapsedEventArgs e)
		{
			takeSnapShot();
		}

		/// <summary>
		/// Take screenshot and save it as PNG image to defined directory
		/// </summary>
		public void takeSnapShot()
		{

			Gdk.Window window = Gdk.Global.DefaultRootWindow;

			if (window != null)
			{           
				Gdk.Pixbuf pixBuf = new Gdk.Pixbuf(Gdk.Colorspace.Rgb, false, 8, window.Screen.Width, window.Screen.Height);
				pixBuf.GetFromDrawable(window, Gdk.Colormap.System, 0, 0, 0, 0, window.Screen.Width, window.Screen.Height);

				var now = DateTime.Now;

				// 2012-12-28
				var dayPath = String.Format("{0:0000}-{1:00}-{2:00}", now.Year, now.Month, now.Day);

				// 235911,213
				var fileName = String.Format("{0:00}{1:00}{2:00},{3}", now.Hour, now.Minute, now.Second, now.Millisecond);

				var savePath = settings.directory + "\\" + dayPath;

				if(!Directory.Exists(savePath))
				{
					// Generate directory
					Directory.CreateDirectory(savePath);
				}

				savePath += "\\" + fileName + ".png";

				// Save screenshot
				pixBuf.Save(savePath, "png");

				lastFileName = savePath;
			}

		}
	}
}

