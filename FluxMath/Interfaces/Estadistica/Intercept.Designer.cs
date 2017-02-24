namespace FluxMath.Interfaces.Estadistica {
  partial class Intercept {
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
      this.textBox_conjunto1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox_conjunto2 = new System.Windows.Forms.TextBox();
      this.textBox_resultado = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button_interceptar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox_conjunto1
      // 
      this.textBox_conjunto1.Location = new System.Drawing.Point(12, 29);
      this.textBox_conjunto1.Name = "textBox_conjunto1";
      this.textBox_conjunto1.Size = new System.Drawing.Size(494, 20);
      this.textBox_conjunto1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Conjunto 1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 59);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Conjunto 2";
      // 
      // textBox_conjunto2
      // 
      this.textBox_conjunto2.Location = new System.Drawing.Point(12, 75);
      this.textBox_conjunto2.Name = "textBox_conjunto2";
      this.textBox_conjunto2.Size = new System.Drawing.Size(494, 20);
      this.textBox_conjunto2.TabIndex = 2;
      // 
      // textBox_resultado
      // 
      this.textBox_resultado.Location = new System.Drawing.Point(12, 118);
      this.textBox_resultado.Name = "textBox_resultado";
      this.textBox_resultado.ReadOnly = true;
      this.textBox_resultado.Size = new System.Drawing.Size(494, 20);
      this.textBox_resultado.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 102);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Resultado";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.SystemColors.Control;
      this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label4.Location = new System.Drawing.Point(12, 161);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(307, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Cada conjunto debe tener los elementos seprarados por comas.";
      // 
      // button_interceptar
      // 
      this.button_interceptar.Cursor = System.Windows.Forms.Cursors.Default;
      this.button_interceptar.Location = new System.Drawing.Point(358, 151);
      this.button_interceptar.Name = "button_interceptar";
      this.button_interceptar.Size = new System.Drawing.Size(147, 23);
      this.button_interceptar.TabIndex = 7;
      this.button_interceptar.Text = "Interceptar conjuntos";
      this.button_interceptar.UseVisualStyleBackColor = true;
      this.button_interceptar.Click += new System.EventHandler(this.button_interceptar_Click);
      // 
      // Intercept
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(518, 186);
      this.Controls.Add(this.button_interceptar);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox_resultado);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox_conjunto2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox_conjunto1);
      this.Name = "Intercept";
      this.Text = "Intercept";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox_conjunto1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox_conjunto2;
    private System.Windows.Forms.TextBox textBox_resultado;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button_interceptar;
  }
}