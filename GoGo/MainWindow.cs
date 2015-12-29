using System;
using Gtk;
using GoGo;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		DbUtils db = new DbUtils ();
		db.CheckDB ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		CheckExit ();
		a.RetVal = true;
	}

	protected void OnSalirActionActivated (object sender, EventArgs e)
	{
		CheckExit ();
	}

	protected void OnFormato1Action1Activated (object sender, EventArgs e)
	{
		AddWindows g = new AddWindows ();
		g.Show ();
	}
	protected void OnFormato2ActionActivated (object sender, EventArgs e)
	{
		AddWindows2 w = new AddWindows2 ();
		w.Show ();
	}

	protected void CheckExit(){

		string mssg = "¿Desea salir del programa?";
		MsgBox mn= new MsgBox();

		if (mn.ShowQuestion (mssg, this) == true) {
			Application.Quit ();
		}
	}


}
