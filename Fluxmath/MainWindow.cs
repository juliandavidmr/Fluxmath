using System;
using Fluxmath;
using Gtk;

public partial class MainWindow : Gtk.Window {
	
	public MainWindow() : base(Gtk.WindowType.Toplevel) {
		Build();
	}

	protected void OnDeleteEvent(object sender,DeleteEventArgs a) {
		Application.Quit();
		a.RetVal = true;
	}

	/**
 	* <summary>Acerca de</summary>
	*/
	protected void OnDialogInfoActionActivated(object sender,EventArgs e) {
		new Acercade().Show();
	}

	/**
	 * <summary>Ventana Ohm</summary>
	*/
	protected void OnConnectActionActivated(object sender,EventArgs e) {
		new Ohm().Show();
	}
}