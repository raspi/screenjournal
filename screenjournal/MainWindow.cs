using System;
using Gtk;
using screenjournal;
using System.Reflection;

public partial class MainWindow: Gtk.Window
{	
	protected snapshotter ss;
	protected ApplicationConfigSection config;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		ss = new snapshotter();
		loadSettings();
	}

	protected void loadSettings()
	{
		// Load configuration file
		config = AppCfg.LoadConfiguration();

		// Set snapshotter settings
		settings settings = new settings();
		
		settings.interval = config.ConfigElement.interval;
		settings.directory = config.ConfigElement.directory;
		
		ss.settings = settings;

		// Update UI

		directorybox.Text = config.ConfigElement.directory;
		intervalbox.Text = config.ConfigElement.interval.ToString();
		folderchooserbutton.SetCurrentFolder(config.ConfigElement.directory);

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

	protected void OnSavesettingsbuttonClicked (object sender, EventArgs e)
	{
		ApplicationConfigSection settings = new ApplicationConfigSection();

		settings.ConfigElement.directory = directorybox.Text;
		settings.ConfigElement.interval = Convert.ToInt32(intervalbox.Text);

		AppCfg.SaveConfiguration(settings);

		loadSettings();
	}

	protected void OnFolderchooserbuttonSelectionChanged (object sender, EventArgs e)
	{
		directorybox.Text = folderchooserbutton.CurrentFolder;
	}
}
