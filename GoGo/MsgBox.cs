using System;
using Gtk;

namespace GoGo
{
	public class MsgBox
	{
		public MsgBox ()
		{
		}
		public void ShowError(string msg, Window win){
			MessageDialog m = new MessageDialog (win, DialogFlags.Modal, MessageType.Error, ButtonsType.Close, msg);
			m.Run ();
			m.Destroy ();
		}
		public void ShowInfo(string msg, Window win){
			MessageDialog m = new MessageDialog (win, DialogFlags.Modal, MessageType.Info, ButtonsType.Close, msg);
			m.Run ();
			m.Destroy ();
		}
		public bool ShowQuestion(string msg, Window win){
			bool accept;
			MessageDialog m = new MessageDialog (win, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, msg);
		
			if ((ResponseType)m.Run () == ResponseType.Yes) {
				accept = true ;
			} else {
				accept = false;
			}
			m.Destroy ();
			return accept; 
		}
		public void ShowWarning(string msg, Window win){
			MessageDialog m = new MessageDialog (win, DialogFlags.Modal, MessageType.Warning, ButtonsType.YesNo, msg);
			m.Run ();
			m.Destroy ();
		}
	}
}

