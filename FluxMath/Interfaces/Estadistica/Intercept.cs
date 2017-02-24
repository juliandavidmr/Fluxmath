using Helpers;
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
  public partial class Intercept : Form {
    public Intercept() {
      InitializeComponent();
    }

    private void button_interceptar_Click(object sender, EventArgs e) {
      string conjunto1 = textBox_conjunto1.Text;
      string conjunto2 = textBox_conjunto2.Text;

      if (!string.IsNullOrEmpty(conjunto1) && !string.IsNullOrEmpty(conjunto2)) {
        List<string> l1 = InterceptHelper.toList(conjunto1).ToArray().ToList<string>();
        List<string> l2 = InterceptHelper.toList(conjunto2).ToArray().ToList<string>();
        string result = String.Join(", ", InterceptHelper.intercept(l1, l2).ToArray());

        textBox_resultado.Text = result;
      }
    }
  }
}
