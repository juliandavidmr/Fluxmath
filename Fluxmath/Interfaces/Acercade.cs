using System;
namespace Fluxmath {
	public partial class Acercade : Gtk.Dialog {
		public Acercade() {
			this.Build();
		}

		protected void OnButtonOkClicked(object sender,EventArgs e) {
			this.Destroy();
		}
	}
}
