
// This file has been generated by the GUI designer. Do not modify.
namespace GoGo
{
	public partial class AddWindows
	{
		private global::Gtk.Fixed fixed1;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Entry entFecha;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Entry entCantidad;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Entry entImporte;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Entry entTotal;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Entry entDestino;
		
		private global::Gtk.Entry entGasolina;
		
		private global::Gtk.Entry entVarios;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView treeData;
		
		private global::Gtk.Button btnCancelar;
		
		private global::Gtk.Button btnNuevo;
		
		private global::Gtk.Button btnActualizar;
		
		private global::Gtk.Button btnEliminar;
		
		private global::Gtk.Button btnGuardar;
		
		private global::Gtk.Button btnLimpiar;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget GoGo.AddWindows
			this.Name = "GoGo.AddWindows";
			this.Title = global::Mono.Unix.Catalog.GetString ("Formato No. 1");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child GoGo.AddWindows.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Fecha");
			this.fixed1.Add (this.label1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
			w1.X = 18;
			w1.Y = 5;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entFecha = new global::Gtk.Entry ();
			this.entFecha.WidthRequest = 85;
			this.entFecha.CanFocus = true;
			this.entFecha.Name = "entFecha";
			this.entFecha.IsEditable = true;
			this.entFecha.MaxLength = 10;
			this.entFecha.InvisibleChar = '•';
			this.fixed1.Add (this.entFecha);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entFecha]));
			w2.X = 13;
			w2.Y = 27;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Destino");
			this.fixed1.Add (this.label2);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label2]));
			w3.X = 108;
			w3.Y = 4;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entCantidad = new global::Gtk.Entry ();
			this.entCantidad.WidthRequest = 83;
			this.entCantidad.CanFocus = true;
			this.entCantidad.Name = "entCantidad";
			this.entCantidad.IsEditable = true;
			this.entCantidad.InvisibleChar = '•';
			this.fixed1.Add (this.entCantidad);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entCantidad]));
			w4.X = 270;
			w4.Y = 26;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Importe / Pollo");
			this.fixed1.Add (this.label4);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label4]));
			w5.X = 369;
			w5.Y = 6;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entImporte = new global::Gtk.Entry ();
			this.entImporte.WidthRequest = 107;
			this.entImporte.CanFocus = true;
			this.entImporte.Name = "entImporte";
			this.entImporte.IsEditable = true;
			this.entImporte.InvisibleChar = '•';
			this.fixed1.Add (this.entImporte);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entImporte]));
			w6.X = 366;
			w6.Y = 26;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Gasolina");
			this.fixed1.Add (this.label5);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label5]));
			w7.X = 487;
			w7.Y = 6;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Varios");
			this.fixed1.Add (this.label6);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label6]));
			w8.X = 559;
			w8.Y = 7;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entTotal = new global::Gtk.Entry ();
			this.entTotal.WidthRequest = 72;
			this.entTotal.CanFocus = true;
			this.entTotal.Name = "entTotal";
			this.entTotal.IsEditable = true;
			this.entTotal.InvisibleChar = '•';
			this.fixed1.Add (this.entTotal);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entTotal]));
			w9.X = 654;
			w9.Y = 26;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Total");
			this.fixed1.Add (this.label7);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label7]));
			w10.X = 669;
			w10.Y = 4;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entDestino = new global::Gtk.Entry ();
			this.entDestino.CanFocus = true;
			this.entDestino.Name = "entDestino";
			this.entDestino.IsEditable = true;
			this.entDestino.InvisibleChar = '•';
			this.fixed1.Add (this.entDestino);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entDestino]));
			w11.X = 103;
			w11.Y = 27;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entGasolina = new global::Gtk.Entry ();
			this.entGasolina.WidthRequest = 65;
			this.entGasolina.CanFocus = true;
			this.entGasolina.Name = "entGasolina";
			this.entGasolina.IsEditable = true;
			this.entGasolina.InvisibleChar = '•';
			this.fixed1.Add (this.entGasolina);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entGasolina]));
			w12.X = 484;
			w12.Y = 26;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entVarios = new global::Gtk.Entry ();
			this.entVarios.WidthRequest = 87;
			this.entVarios.CanFocus = true;
			this.entVarios.Name = "entVarios";
			this.entVarios.IsEditable = true;
			this.entVarios.InvisibleChar = '•';
			this.fixed1.Add (this.entVarios);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entVarios]));
			w13.X = 558;
			w13.Y = 26;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Cant. / Pollo");
			this.fixed1.Add (this.label3);
			global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label3]));
			w14.X = 270;
			w14.Y = 5;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.WidthRequest = 716;
			this.GtkScrolledWindow.HeightRequest = 319;
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeData = new global::Gtk.TreeView ();
			this.treeData.CanFocus = true;
			this.treeData.Name = "treeData";
			this.GtkScrolledWindow.Add (this.treeData);
			this.fixed1.Add (this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.GtkScrolledWindow]));
			w16.X = 14;
			w16.Y = 116;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnCancelar = new global::Gtk.Button ();
			this.btnCancelar.WidthRequest = 100;
			this.btnCancelar.CanFocus = true;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.UseUnderline = true;
			this.btnCancelar.Label = global::Mono.Unix.Catalog.GetString ("_Cancelar");
			global::Gtk.Image w17 = new global::Gtk.Image ();
			w17.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.btnCancelar.Image = w17;
			this.fixed1.Add (this.btnCancelar);
			global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnCancelar]));
			w18.X = 628;
			w18.Y = 76;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnNuevo = new global::Gtk.Button ();
			this.btnNuevo.WidthRequest = 100;
			this.btnNuevo.CanFocus = true;
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.UseUnderline = true;
			this.btnNuevo.Label = global::Mono.Unix.Catalog.GetString ("Nuevo");
			global::Gtk.Image w19 = new global::Gtk.Image ();
			w19.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-new", global::Gtk.IconSize.Menu);
			this.btnNuevo.Image = w19;
			this.fixed1.Add (this.btnNuevo);
			global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnNuevo]));
			w20.X = 14;
			w20.Y = 75;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnActualizar = new global::Gtk.Button ();
			this.btnActualizar.WidthRequest = 100;
			this.btnActualizar.CanFocus = true;
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.UseUnderline = true;
			this.btnActualizar.Label = global::Mono.Unix.Catalog.GetString ("_Actualizar");
			global::Gtk.Image w21 = new global::Gtk.Image ();
			w21.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-refresh", global::Gtk.IconSize.Menu);
			this.btnActualizar.Image = w21;
			this.fixed1.Add (this.btnActualizar);
			global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnActualizar]));
			w22.X = 127;
			w22.Y = 75;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnEliminar = new global::Gtk.Button ();
			this.btnEliminar.WidthRequest = 100;
			this.btnEliminar.CanFocus = true;
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.UseUnderline = true;
			this.btnEliminar.Label = global::Mono.Unix.Catalog.GetString ("_Eliminar");
			global::Gtk.Image w23 = new global::Gtk.Image ();
			w23.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.btnEliminar.Image = w23;
			this.fixed1.Add (this.btnEliminar);
			global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnEliminar]));
			w24.X = 237;
			w24.Y = 76;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnGuardar = new global::Gtk.Button ();
			this.btnGuardar.WidthRequest = 100;
			this.btnGuardar.CanFocus = true;
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.UseUnderline = true;
			this.btnGuardar.Label = global::Mono.Unix.Catalog.GetString ("_Guardar");
			global::Gtk.Image w25 = new global::Gtk.Image ();
			w25.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			this.btnGuardar.Image = w25;
			this.fixed1.Add (this.btnGuardar);
			global::Gtk.Fixed.FixedChild w26 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnGuardar]));
			w26.X = 348;
			w26.Y = 76;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnLimpiar = new global::Gtk.Button ();
			this.btnLimpiar.WidthRequest = 100;
			this.btnLimpiar.CanFocus = true;
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.UseUnderline = true;
			this.btnLimpiar.Label = global::Mono.Unix.Catalog.GetString ("_Limpiar");
			global::Gtk.Image w27 = new global::Gtk.Image ();
			w27.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-clear", global::Gtk.IconSize.Menu);
			this.btnLimpiar.Image = w27;
			this.fixed1.Add (this.btnLimpiar);
			global::Gtk.Fixed.FixedChild w28 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnLimpiar]));
			w28.X = 458;
			w28.Y = 75;
			this.Add (this.fixed1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 738;
			this.DefaultHeight = 466;
			this.Show ();
			this.entVarios.TextInserted += new global::Gtk.TextInsertedHandler (this.OnEntVariosTextInserted);
			this.treeData.CursorChanged += new global::System.EventHandler (this.OnTreeDataCursorChanged);
			this.btnCancelar.Clicked += new global::System.EventHandler (this.OnBtnCancelarClicked);
			this.btnNuevo.Clicked += new global::System.EventHandler (this.OnBtnNuevoClicked);
			this.btnActualizar.Clicked += new global::System.EventHandler (this.OnBtnActualizarClicked);
			this.btnEliminar.Clicked += new global::System.EventHandler (this.OnBtnEliminarClicked);
			this.btnGuardar.Clicked += new global::System.EventHandler (this.OnBtnGuardarClicked);
			this.btnLimpiar.Clicked += new global::System.EventHandler (this.OnBtnLimpiarClicked);
		}
	}
}
