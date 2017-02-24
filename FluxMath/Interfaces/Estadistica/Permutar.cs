using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxMath.Interfaces.Estadistica {
  public partial class Permutar : Form {
    public Permutar() {
      InitializeComponent();
    }

    private void textBox2_TextChanged(object sender, EventArgs e) {
      calc_permutacion();
    }

    private void textBox_n_TextChanged(object sender, EventArgs e) {
      calc_permutacion();
    }

    public void calc_permutacion() {
      try {
        long n = Convert.ToInt64(textBox_n.Text);
        long r = Convert.ToInt64(textBox_r.Text);
        textBox_result.Text = Helpers.PermutacionHelper.nDistint(n, r).ToString();
      } catch (Exception) {
        
      }
    }
  }
}
