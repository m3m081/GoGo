
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action ArchivoAction;
	
	private global::Gtk.Action FormatosDeCapturaAction;
	
	private global::Gtk.Action Formato1Action;
	
	private global::Gtk.Action Formtao2Action;
	
	private global::Gtk.Action SalirAction;
	
	private global::Gtk.Action Formato1Action1;
	
	private global::Gtk.Action Formato2Action;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.MenuBar menubar1;
	
	private global::Gtk.HPaned hpaned1;
	
	private global::Gtk.Statusbar statusbar1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.ArchivoAction = new global::Gtk.Action ("ArchivoAction", global::Mono.Unix.Catalog.GetString ("_Archivo"), null, null);
		this.ArchivoAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Archivo");
		w1.Add (this.ArchivoAction, null);
		this.FormatosDeCapturaAction = new global::Gtk.Action ("FormatosDeCapturaAction", global::Mono.Unix.Catalog.GetString ("Formatos de Captura"), null, null);
		this.FormatosDeCapturaAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Formatos de Captura");
		w1.Add (this.FormatosDeCapturaAction, null);
		this.Formato1Action = new global::Gtk.Action ("Formato1Action", global::Mono.Unix.Catalog.GetString ("Formato # 1"), null, null);
		this.Formato1Action.ShortLabel = global::Mono.Unix.Catalog.GetString ("Formato # 1");
		w1.Add (this.Formato1Action, null);
		this.Formtao2Action = new global::Gtk.Action ("Formtao2Action", global::Mono.Unix.Catalog.GetString ("Formtao # 2"), null, null);
		this.Formtao2Action.ShortLabel = global::Mono.Unix.Catalog.GetString ("Formtao # 2");
		w1.Add (this.Formtao2Action, null);
		this.SalirAction = new global::Gtk.Action ("SalirAction", global::Mono.Unix.Catalog.GetString ("_Salir"), null, null);
		this.SalirAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Salir");
		w1.Add (this.SalirAction, null);
		this.Formato1Action1 = new global::Gtk.Action ("Formato1Action1", global::Mono.Unix.Catalog.GetString ("Formato #1"), null, null);
		this.Formato1Action1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Formato #1");
		w1.Add (this.Formato1Action1, null);
		this.Formato2Action = new global::Gtk.Action ("Formato2Action", global::Mono.Unix.Catalog.GetString ("Formato #2"), null, null);
		this.Formato2Action.ShortLabel = global::Mono.Unix.Catalog.GetString ("Formato #2");
		w1.Add (this.Formato2Action, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Control de Salida de Mercancia y Gastos");
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "stock_home", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='ArchivoAction' action='ArchivoAction'><menuitem name='SalirAction' action='SalirAction'/></menu><menu name='FormatosDeCapturaAction' action='FormatosDeCapturaAction'><menuitem name='Formato1Action1' action='Formato1Action1'/><menuitem name='Formato2Action' action='Formato2Action'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hpaned1 = new global::Gtk.HPaned ();
		this.hpaned1.CanFocus = true;
		this.hpaned1.Name = "hpaned1";
		this.hpaned1.Position = 97;
		this.vbox1.Add (this.hpaned1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hpaned1]));
		w3.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox1.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar1]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 509;
		this.DefaultHeight = 239;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		//this.Formato1Action.Activated += new global::System.EventHandler (this.OnFormato1ActionActivated);
		//this.Formtao2Action.Activated += new global::System.EventHandler (this.OnFormtao2ActionActivated);
		this.SalirAction.Activated += new global::System.EventHandler (this.OnSalirActionActivated);
		this.Formato1Action1.Activated += new global::System.EventHandler (this.OnFormato1Action1Activated);
		this.Formato2Action.Activated += new global::System.EventHandler (this.OnFormato2ActionActivated);
	}
}