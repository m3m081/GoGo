using System;
using GoGo;
using Gtk;

namespace GoGo
{
	public partial class AddWindows : Gtk.Window
	{

		ListStore model= new ListStore(typeof(int), typeof(string), typeof(string), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float)); 
		int id; 

		public AddWindows () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			CreateTree ();
		}

		protected void OnBtnCancelarClicked (object sender, EventArgs e)
		{
			this.Destroy ();
		}
		protected void clean(){

			entDestino.Text = "";
			entCantidad.Text = "";
			entImporte.Text = "";
			entGasolina.Text = "";
			entVarios.Text = "";

		}
		protected void RefreshTree(){
			DbUtils ldata = new DbUtils();
			model= ldata.LoadData();
			treeData.Model = model ;
			treeData.QueueDraw ();
		}
		protected void CreateTree(){
		//TODO: Check if exists any way to adjust columns width
			DbUtils ldata = new DbUtils();
			model= ldata.LoadData();
			treeData.Model = model ;

			treeData.AppendColumn ("Id", new Gtk.CellRendererText (), "text", 0);
			treeData.AppendColumn ("Fecha", new Gtk.CellRendererText (), "text", 1);
			treeData.AppendColumn ("Destino", new Gtk.CellRendererText (), "text", 2);
			treeData.AppendColumn ("Cant.", new Gtk.CellRendererText (), "text", 3);
			treeData.AppendColumn ("Importe", new Gtk.CellRendererText (), "text", 4);
			treeData.AppendColumn ("Gasolina", new Gtk.CellRendererText (), "text", 5);
			treeData.AppendColumn ("Varios", new Gtk.CellRendererText (), "text", 6);
			treeData.AppendColumn ("Total", new Gtk.CellRendererText (), "text", 7);

			treeData.ColumnsAutosize();
		}

		protected void OnBtnLimpiarClicked (object sender, EventArgs e)
		{
			WindowSearch m = new WindowSearch ();
			m.Show ();
		}

		protected void OnBtnNuevoClicked (object sender, EventArgs e)
		{
			clean ();
			entFecha.Text = DateTime.Now.ToString ();
		}

		protected void OnBtnActualizarClicked (object sender, EventArgs e)
		{
			try {
				DbUtils db = new DbUtils ();
				db.Update(entFecha.Text,entDestino.Text,entCantidad.Text,entImporte.Text,entGasolina.Text,entVarios.Text,entTotal.Text,id);
			}catch (Exception ex){
				Console.WriteLine("The process failed: {0}", ex.ToString());
			}
			clean ();
			RefreshTree ();
		}

		protected void OnBtnEliminarClicked (object sender, EventArgs e)
		{
			    string mssg = "¿Desea eliminar el registro seleccionado?";
				MsgBox mn= new MsgBox();

				if (mn.ShowQuestion (mssg, this) == true) {

					if (id != 0) {
						try {
							DbUtils db = new DbUtils ();
							db.Delete (id);
						} catch (Exception ex) {
							Console.WriteLine ("The process failed: {0}", ex.ToString ());
						}
						clean ();
						RefreshTree ();
						mssg = "Registro Eliminado";
					MsgBox me=new  MsgBox();
						me.ShowInfo(mssg,this);

					}
				}
		}

		protected void OnBtnGuardarClicked (object sender, EventArgs e)
		{
			string Ms;

			if (entDestino.Text == "" || entCantidad.Text == "" || entImporte.Text == ""|| entGasolina.Text  == ""|| entVarios.Text== "") {

				Ms="No se puede insertar el registro, alguno de los campos vacios son obligatorios";
				MsgBox m = new MsgBox() ;
				m.ShowError (Ms,this);

			}else{
				try {
					DbUtils db = new DbUtils ();
					db.Insert (entFecha.Text,entDestino.Text,entCantidad.Text,entImporte.Text,entGasolina.Text,entVarios.Text,entTotal.Text );
				}catch (Exception ex){
					Console.WriteLine("The process failed: {0}", ex.ToString());
				}
				Ms="Los datos se han insertado correctamente";
				MsgBox m = new MsgBox() ;
				m.ShowInfo  (Ms,this);
			}

			clean ();
			RefreshTree ();
		}

		protected void OnEntVariosTextInserted (object o, TextInsertedArgs args)
		{
			float total,importe,gasolina,varios;
			int cantidad;
			if (entCantidad.Text ==""||entImporte.Text==""|| entGasolina.Text==""|| entVarios.Text==""){

				entTotal.Text ="";

			}else{

				cantidad = int.Parse(entCantidad.Text);
				importe = float.Parse(entImporte.Text);
				gasolina = float.Parse(entGasolina.Text);
				varios = float.Parse(entVarios.Text);

				total =cantidad + importe + gasolina + varios ;

				entTotal.Text = total.ToString ();
			}
		}

		protected void OnTreeDataCursorChanged (object sender, EventArgs e)
		{
			TreeSelection sel = (sender as TreeView).Selection;
			TreeModel model;
			TreeIter iter;

			if(sel.GetSelected(out model, out iter))
			{
				id =  Convert.ToInt32(model.GetValue (iter, 0));
				entFecha.Text = model.GetValue (iter, 1).ToString();
				entDestino.Text =  model.GetValue (iter, 2).ToString();
				entCantidad.Text =  model.GetValue (iter, 3).ToString();
				entImporte.Text =  model.GetValue (iter, 4).ToString();
				entGasolina.Text =  model.GetValue (iter, 5).ToString();
				entVarios.Text =  model.GetValue (iter, 6).ToString();
			}
		}
	}
}

