
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow {
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action ArchivoAction;

	private global::Gtk.Action SalirAction;

	private global::Gtk.Action newAction;

	private global::Gtk.Action cancelAction;

	private global::Gtk.Action AyudaAction;

	private global::Gtk.Action dndMultipleAction;

	private global::Gtk.Action dialogInfoAction;

	private global::Gtk.Action HerramientasAction;

	private global::Gtk.Action harddiskAction;

	private global::Gtk.Action connectAction;

	private global::Gtk.VBox vbox1;

	private global::Gtk.MenuBar menubar6;

	protected virtual void Build() {
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.ArchivoAction = new global::Gtk.Action("ArchivoAction",global::Mono.Unix.Catalog.GetString("Archivo"),null,null);
		this.ArchivoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Archivo");
		w1.Add(this.ArchivoAction,null);
		this.SalirAction = new global::Gtk.Action("SalirAction",global::Mono.Unix.Catalog.GetString("Salir"),null,null);
		this.SalirAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Salir");
		w1.Add(this.SalirAction,null);
		this.newAction = new global::Gtk.Action("newAction",global::Mono.Unix.Catalog.GetString("Nueva ventana"),null,"gtk-new");
		this.newAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Nueva ventana");
		w1.Add(this.newAction,null);
		this.cancelAction = new global::Gtk.Action("cancelAction",global::Mono.Unix.Catalog.GetString("Salir"),null,"gtk-cancel");
		this.cancelAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Salir");
		w1.Add(this.cancelAction,null);
		this.AyudaAction = new global::Gtk.Action("AyudaAction",global::Mono.Unix.Catalog.GetString("Ayuda"),null,null);
		this.AyudaAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Ayuda");
		w1.Add(this.AyudaAction,null);
		this.dndMultipleAction = new global::Gtk.Action("dndMultipleAction",global::Mono.Unix.Catalog.GetString("Documentación"),null,"gtk-dnd-multiple");
		this.dndMultipleAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Documentación");
		w1.Add(this.dndMultipleAction,null);
		this.dialogInfoAction = new global::Gtk.Action("dialogInfoAction",global::Mono.Unix.Catalog.GetString("Acerca de"),global::Mono.Unix.Catalog.GetString("Información acerca de este programa."),"gtk-dialog-info");
		this.dialogInfoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Acerca de");
		w1.Add(this.dialogInfoAction,"F1");
		this.HerramientasAction = new global::Gtk.Action("HerramientasAction",global::Mono.Unix.Catalog.GetString("Herramientas"),null,null);
		this.HerramientasAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Herramientas");
		w1.Add(this.HerramientasAction,null);
		this.harddiskAction = new global::Gtk.Action("harddiskAction",global::Mono.Unix.Catalog.GetString("Electronica_"),null,"gtk-harddisk");
		this.harddiskAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Electronica_");
		w1.Add(this.harddiskAction,null);
		this.connectAction = new global::Gtk.Action("connectAction",global::Mono.Unix.Catalog.GetString("Ohm"),null,"gtk-connect");
		this.connectAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Ohm");
		w1.Add(this.connectAction,null);
		this.UIManager.InsertActionGroup(w1,0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition) (4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name='menubar6'><menu name='ArchivoAction' action='ArchivoAction'><menuitem name='newAction' action='newAction'/><separator/><menuitem name='cancelAction' action='cancelAction'/></menu><menu name='HerramientasAction' action='HerramientasAction'><menu name='harddiskAction' action='harddiskAction'><menuitem name='connectAction' action='connectAction'/></menu></menu><menu name='AyudaAction' action='AyudaAction'><menuitem name='dndMultipleAction' action='dndMultipleAction'/><menuitem name='dialogInfoAction' action='dialogInfoAction'/></menu></menubar></ui>");
		this.menubar6 = ((global::Gtk.MenuBar) (this.UIManager.GetWidget("/menubar6")));
		this.menubar6.Name = "menubar6";
		this.vbox1.Add(this.menubar6);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild) (this.vbox1[this.menubar6]));
		w2.Position = 0;
		w2.Expand = false;
		this.Add(this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll();
		}
		this.DefaultWidth = 923;
		this.DefaultHeight = 547;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.dialogInfoAction.Activated += new global::System.EventHandler(this.OnDialogInfoActionActivated);
		this.connectAction.Activated += new global::System.EventHandler(this.OnConnectActionActivated);
	}
}
