namespace FluxMath.Interfaces.Estadistica {
  partial class Permutar {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.textBox_n = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox_r = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox_result = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(156, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "El numero de permutaciones de";
      // 
      // textBox_n
      // 
      this.textBox_n.Location = new System.Drawing.Point(175, 10);
      this.textBox_n.Name = "textBox_n";
      this.textBox_n.Size = new System.Drawing.Size(71, 20);
      this.textBox_n.TabIndex = 1;
      this.textBox_n.TextChanged += new System.EventHandler(this.textBox_n_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(252, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(143, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "elementos distintos, tomando";
      // 
      // textBox_r
      // 
      this.textBox_r.Location = new System.Drawing.Point(401, 10);
      this.textBox_r.Name = "textBox_r";
      this.textBox_r.Size = new System.Drawing.Size(71, 20);
      this.textBox_r.TabIndex = 3;
      this.textBox_r.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(478, 13);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "a la vez, es:";
      // 
      // textBox_result
      // 
      this.textBox_result.Location = new System.Drawing.Point(548, 10);
      this.textBox_result.Name = "textBox_result";
      this.textBox_result.Size = new System.Drawing.Size(71, 20);
      this.textBox_result.TabIndex = 5;
      // 
      // Permutar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(627, 42);
      this.Controls.Add(this.textBox_result);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox_r);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox_n);
      this.Controls.Add(this.label1);
      this.Name = "Permutar";
      this.Text = "Permutar";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox_n;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox_r;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox_result;
  }
}