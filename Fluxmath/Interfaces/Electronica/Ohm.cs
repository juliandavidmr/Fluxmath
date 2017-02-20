using System;
namespace Fluxmath {
	public partial class Ohm : Gtk.Window {
		public Ohm() :
				base(Gtk.WindowType.Toplevel) {
			this.Build();
		}

		protected void OnInputVoltajeChanged(object sender,EventArgs e) {
			calc_i();
		}

		protected void OnInputResistenciaChanged(object sender,EventArgs e) {
			calc_i();
		}

		private void calc_i() {
			string voltaje = input_voltaje.Text;
			string resistencia = input_resistencia.Text;

			if (!string.IsNullOrEmpty(voltaje) && !string.IsNullOrEmpty(resistencia)) {
				try {
					float r = (float) Convert.ToDouble(resistencia);
					float v = (float) Convert.ToDouble(voltaje);
					output_corriente.Text = (Helpers.OhmHelper.getI(v,r)).ToString();
				} catch {
				}
			}
		}

		protected void OnInputCorrienteChanged(object sender,EventArgs e) {
			calc_v();
		}

		protected void OnInputResistencia1Changed(object sender,EventArgs e) {
			calc_v();
		}

		private void calc_v() {
			string corriente = input_corriente.Text;
			string resistencia = input_resistencia1.Text;

			if (!string.IsNullOrEmpty(corriente) && !string.IsNullOrEmpty(resistencia)) {
				try {
					float r = (float) Convert.ToDouble(resistencia);
					float i = (float) Convert.ToDouble(corriente);
					output_voltaje.Text = (Helpers.OhmHelper.getV(i, r)).ToString();
				} catch {
				}
			}
		}

		protected void OnInputVoltaje1Changed(object sender,EventArgs e) {
			calc_r();
		}

		protected void OnInputCorriente1Changed(object sender,EventArgs e) {
			calc_r();
		}

		private void calc_r() {
			string voltaje = input_voltaje1.Text;
			string corriente = input_corriente1.Text;

			if (!string.IsNullOrEmpty(voltaje) && !string.IsNullOrEmpty(corriente)) {
				try {
					float i = (float) Convert.ToDouble(corriente);
					float v = (float) Convert.ToDouble(voltaje);
					output_resistencia.Text = (Helpers.OhmHelper.getV(v,i)).ToString();
				} catch {
				}
			}
		}
	}
}
