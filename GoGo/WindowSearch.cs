using System;

namespace GoGo
{
	public partial class WindowSearch : Gtk.Window
	{
		public WindowSearch () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnBtnCancelActivated (object sender, EventArgs e)
		{

		}

		protected void OnBtnCancelClicked (object sender, EventArgs e)
		{
			this.Destroy ();
		}
	}
}

