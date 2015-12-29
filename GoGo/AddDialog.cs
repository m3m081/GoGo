using System;

namespace GoGo
{
	public partial class AddDialog : Gtk.Dialog
	{
		public AddDialog ()
		{
			this.Build ();
		}

		protected void OnButtonCancelClicked (object sender, EventArgs e)
		{
			this.Destroy ();
		}
	}
}

