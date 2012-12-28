using System;
using Gtk;
using screenjournal;
using System.Reflection;

public partial class MainWindow: Gtk.Window
{	
	protected snapshotter ss;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		ss = new snapshotter();

	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnRunbuttonClicked (object sender, EventArgs e)
	{

		if(!ss.isRunning)
		{
			ss.runThread();
			runbutton.Label = "Recording...";
		}
		else
		{
			ss.stopThread();
			runbutton.Label = "Start recording";
		}
	}
}
