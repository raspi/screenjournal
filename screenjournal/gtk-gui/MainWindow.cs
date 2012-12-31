
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.VBox vbox1;
	private global::Gtk.Notebook notebook1;
	private global::Gtk.VBox vboxrun;
	private global::Gtk.Button runbutton;
	private global::Gtk.Button runbuttonrunning;
	private global::Gtk.Label runtab;
	private global::Gtk.VBox vboxsettings;
	private global::Gtk.HBox hbox2;
	private global::Gtk.HBox hbox1;
	private global::Gtk.FileChooserButton folderchooserbutton;
	private global::Gtk.Entry directorybox;
	private global::Gtk.Label label3;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Label label4;
	private global::Gtk.SpinButton intervalbox;
	private global::Gtk.Button savesettingsbutton;
	private global::Gtk.Label settingstab;
	private global::Gtk.Statusbar statusbar1;
	private global::Gtk.Label statusbarlabel;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.WidthRequest = 640;
		this.HeightRequest = 480;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("ScreenJournal");
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-media-record", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.DefaultWidth = 640;
		this.DefaultHeight = 480;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.BorderWidth = ((uint)(2));
		// Container child vbox1.Gtk.Box+BoxChild
		this.notebook1 = new global::Gtk.Notebook ();
		this.notebook1.CanFocus = true;
		this.notebook1.Name = "notebook1";
		this.notebook1.CurrentPage = 1;
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.vboxrun = new global::Gtk.VBox ();
		this.vboxrun.Name = "vboxrun";
		this.vboxrun.Spacing = 6;
		// Container child vboxrun.Gtk.Box+BoxChild
		this.runbutton = new global::Gtk.Button ();
		this.runbutton.Name = "runbutton";
		this.runbutton.UseUnderline = true;
		// Container child runbutton.Gtk.Container+ContainerChild
		global::Gtk.Alignment w2 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w3 = new global::Gtk.HBox ();
		w3.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w4 = new global::Gtk.Image ();
		w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-media-stop", global::Gtk.IconSize.Button);
		w3.Add (w4);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w6 = new global::Gtk.Label ();
		w6.LabelProp = global::Mono.Unix.Catalog.GetString ("Start recording");
		w6.UseUnderline = true;
		w3.Add (w6);
		w2.Add (w3);
		this.runbutton.Add (w2);
		this.vboxrun.Add (this.runbutton);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vboxrun [this.runbutton]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vboxrun.Gtk.Box+BoxChild
		this.runbuttonrunning = new global::Gtk.Button ();
		this.runbuttonrunning.Name = "runbuttonrunning";
		this.runbuttonrunning.UseUnderline = true;
		// Container child runbuttonrunning.Gtk.Container+ContainerChild
		global::Gtk.Alignment w11 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w12 = new global::Gtk.HBox ();
		w12.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w13 = new global::Gtk.Image ();
		w13.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-media-record", global::Gtk.IconSize.Button);
		w12.Add (w13);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w15 = new global::Gtk.Label ();
		w15.LabelProp = global::Mono.Unix.Catalog.GetString ("Stop recording");
		w15.UseUnderline = true;
		w12.Add (w15);
		w11.Add (w12);
		this.runbuttonrunning.Add (w11);
		this.vboxrun.Add (this.runbuttonrunning);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vboxrun [this.runbuttonrunning]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		this.notebook1.Add (this.vboxrun);
		// Notebook tab
		this.runtab = new global::Gtk.Label ();
		this.runtab.CanDefault = true;
		this.runtab.Name = "runtab";
		this.runtab.LabelProp = global::Mono.Unix.Catalog.GetString ("Run");
		this.notebook1.SetTabLabel (this.vboxrun, this.runtab);
		this.runtab.ShowAll ();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.vboxsettings = new global::Gtk.VBox ();
		this.vboxsettings.Name = "vboxsettings";
		this.vboxsettings.BorderWidth = ((uint)(2));
		// Container child vboxsettings.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.BorderWidth = ((uint)(2));
		// Container child hbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.folderchooserbutton = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select A Folder"), ((global::Gtk.FileChooserAction)(2)));
		this.folderchooserbutton.WidthRequest = 1;
		this.folderchooserbutton.Name = "folderchooserbutton";
		this.hbox1.Add (this.folderchooserbutton);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.folderchooserbutton]));
		w21.PackType = ((global::Gtk.PackType)(1));
		w21.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.directorybox = new global::Gtk.Entry ();
		this.directorybox.CanFocus = true;
		this.directorybox.Name = "directorybox";
		this.directorybox.IsEditable = true;
		this.directorybox.InvisibleChar = '●';
		this.hbox1.Add (this.directorybox);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.directorybox]));
		w22.PackType = ((global::Gtk.PackType)(1));
		w22.Position = 1;
		this.hbox2.Add (this.hbox1);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.hbox1]));
		w23.PackType = ((global::Gtk.PackType)(1));
		w23.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Image save directory");
		this.label3.Justify = ((global::Gtk.Justification)(1));
		this.label3.SingleLineMode = true;
		this.hbox2.Add (this.label3);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label3]));
		w24.PackType = ((global::Gtk.PackType)(1));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
		this.vboxsettings.Add (this.hbox2);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vboxsettings [this.hbox2]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		// Container child vboxsettings.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.BorderWidth = ((uint)(2));
		// Container child hbox3.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Interval (seconds)");
		this.label4.Justify = ((global::Gtk.Justification)(1));
		this.label4.SingleLineMode = true;
		this.hbox3.Add (this.label4);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label4]));
		w26.Position = 0;
		w26.Expand = false;
		w26.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.intervalbox = new global::Gtk.SpinButton (1D, 86400D, 1D);
		this.intervalbox.WidthRequest = 60;
		this.intervalbox.CanFocus = true;
		this.intervalbox.Name = "intervalbox";
		this.intervalbox.Adjustment.PageIncrement = 1D;
		this.intervalbox.Adjustment.PageSize = 30D;
		this.intervalbox.ClimbRate = 1D;
		this.intervalbox.Numeric = true;
		this.intervalbox.Value = 1D;
		this.hbox3.Add (this.intervalbox);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.intervalbox]));
		w27.PackType = ((global::Gtk.PackType)(1));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		this.vboxsettings.Add (this.hbox3);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vboxsettings [this.hbox3]));
		w28.Position = 1;
		w28.Expand = false;
		w28.Fill = false;
		// Container child vboxsettings.Gtk.Box+BoxChild
		this.savesettingsbutton = new global::Gtk.Button ();
		this.savesettingsbutton.CanFocus = true;
		this.savesettingsbutton.Name = "savesettingsbutton";
		this.savesettingsbutton.UseUnderline = true;
		// Container child savesettingsbutton.Gtk.Container+ContainerChild
		global::Gtk.Alignment w29 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w30 = new global::Gtk.HBox ();
		w30.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w31 = new global::Gtk.Image ();
		w31.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
		w30.Add (w31);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w33 = new global::Gtk.Label ();
		w33.LabelProp = global::Mono.Unix.Catalog.GetString ("Save settings");
		w33.UseUnderline = true;
		w30.Add (w33);
		w29.Add (w30);
		this.savesettingsbutton.Add (w29);
		this.vboxsettings.Add (this.savesettingsbutton);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vboxsettings [this.savesettingsbutton]));
		w37.PackType = ((global::Gtk.PackType)(1));
		w37.Position = 2;
		w37.Expand = false;
		w37.Fill = false;
		this.notebook1.Add (this.vboxsettings);
		global::Gtk.Notebook.NotebookChild w38 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vboxsettings]));
		w38.Position = 1;
		// Notebook tab
		this.settingstab = new global::Gtk.Label ();
		this.settingstab.Name = "settingstab";
		this.settingstab.LabelProp = global::Mono.Unix.Catalog.GetString ("Settings");
		this.notebook1.SetTabLabel (this.vboxsettings, this.settingstab);
		this.settingstab.ShowAll ();
		this.vbox1.Add (this.notebook1);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.notebook1]));
		w39.Position = 0;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 1;
		// Container child statusbar1.Gtk.Box+BoxChild
		this.statusbarlabel = new global::Gtk.Label ();
		this.statusbarlabel.Name = "statusbarlabel";
		this.statusbarlabel.Wrap = true;
		this.statusbar1.Add (this.statusbarlabel);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.statusbar1 [this.statusbarlabel]));
		w40.Position = 0;
		w40.Expand = false;
		w40.Fill = false;
		this.vbox1.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar1]));
		w41.Position = 1;
		w41.Expand = false;
		w41.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.runbuttonrunning.Hide ();
		this.runtab.HasDefault = true;
		this.Show ();
		this.runbutton.Clicked += new global::System.EventHandler (this.OnRunbuttonClicked);
		this.runbuttonrunning.Clicked += new global::System.EventHandler (this.OnRunbuttonClicked);
		this.folderchooserbutton.SelectionChanged += new global::System.EventHandler (this.OnFolderchooserbuttonSelectionChanged);
		this.savesettingsbutton.Clicked += new global::System.EventHandler (this.OnSavesettingsbuttonClicked);
	}
}
