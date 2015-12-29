using System;

namespace GoGo
{
	public partial class AddWindows2 : Gtk.Window
		{
		string Ms;
		public AddWindows2 () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnBtnCancelClicked (object sender, EventArgs e)
		{
			this.Destroy ();
		}

		protected void OnBtnNuevoClicked (object sender, EventArgs e)
		{
			Info ();
		}
		protected void Info(){
			Ms="Caracteristica no implementada aun";
			MsgBox m = new MsgBox() ;
			m.ShowInfo (Ms,this);
		}
		protected void Alerta(){
			Ms="Caracteristica no implementada aun";
			MsgBox m = new MsgBox() ;
			m.ShowWarning (Ms,this);
		}
		protected void Pregunta(){
			Ms="Caracteristica no implementada aun";
			MsgBox m = new MsgBox() ;

			if(m.ShowQuestion (Ms,this)==true) {
				Alerta ();
			}else{
				Info ();
			}

		}
		protected void Error(){
			Ms="Caracteristica no implementada aun";
			MsgBox m = new MsgBox() ;
			m.ShowError (Ms,this);
		}
		protected void OnBtnActualizarClicked (object sender, EventArgs e)
		{
			Alerta ();
		}

		protected void OnBtnBorrarClicked (object sender, EventArgs e)
		{
			Error ();
		}

		protected void OnBtnGuardarClicked (object sender, EventArgs e)
		{
			Pregunta ();
		}

		protected void OnBtnLimpiarClicked (object sender, EventArgs e)
		{
			Info ();
		}

		protected void OnBtnBuscarClicked (object sender, EventArgs e)
		{
			Report rpt = new Report ();

			rpt.ShowReport ();
		}
	}
}

