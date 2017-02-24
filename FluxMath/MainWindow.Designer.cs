namespace FluxMath {
  partial class MainWindow {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.electronicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ohmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.estadisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.basicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.intercepciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.documentaciònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.permutacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tomandoRElementosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(595, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // archivoToolStripMenuItem
      // 
      this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
      this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
      this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
      this.archivoToolStripMenuItem.Text = "&Archivo";
      // 
      // salirToolStripMenuItem
      // 
      this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
      this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
      this.salirToolStripMenuItem.Text = "Salir";
      // 
      // herramientasToolStripMenuItem
      // 
      this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.electronicaToolStripMenuItem,
            this.estadisticaToolStripMenuItem});
      this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
      this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
      this.herramientasToolStripMenuItem.Text = "&Herramientas";
      this.herramientasToolStripMenuItem.Click += new System.EventHandler(this.herramientasToolStripMenuItem_Click);
      // 
      // electronicaToolStripMenuItem
      // 
      this.electronicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ohmToolStripMenuItem});
      this.electronicaToolStripMenuItem.Name = "electronicaToolStripMenuItem";
      this.electronicaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.electronicaToolStripMenuItem.Text = "&Electronica";
      // 
      // ohmToolStripMenuItem
      // 
      this.ohmToolStripMenuItem.Name = "ohmToolStripMenuItem";
      this.ohmToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
      this.ohmToolStripMenuItem.Text = "Ohm";
      this.ohmToolStripMenuItem.Click += new System.EventHandler(this.ohmToolStripMenuItem_Click);
      // 
      // estadisticaToolStripMenuItem
      // 
      this.estadisticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicoToolStripMenuItem,
            this.intercepciónToolStripMenuItem,
            this.permutacionesToolStripMenuItem});
      this.estadisticaToolStripMenuItem.Name = "estadisticaToolStripMenuItem";
      this.estadisticaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.estadisticaToolStripMenuItem.Text = "&Estadistica";
      // 
      // basicoToolStripMenuItem
      // 
      this.basicoToolStripMenuItem.Name = "basicoToolStripMenuItem";
      this.basicoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
      this.basicoToolStripMenuItem.Text = "Basico";
      // 
      // intercepciónToolStripMenuItem
      // 
      this.intercepciónToolStripMenuItem.Name = "intercepciónToolStripMenuItem";
      this.intercepciónToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
      this.intercepciónToolStripMenuItem.Text = "Intercepción";
      this.intercepciónToolStripMenuItem.Click += new System.EventHandler(this.intercepciónToolStripMenuItem_Click);
      // 
      // ayudaToolStripMenuItem
      // 
      this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentaciònToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
      this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
      this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
      this.ayudaToolStripMenuItem.Text = "&Ayuda";
      // 
      // documentaciònToolStripMenuItem
      // 
      this.documentaciònToolStripMenuItem.Name = "documentaciònToolStripMenuItem";
      this.documentaciònToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
      this.documentaciònToolStripMenuItem.Text = "&Documentaciòn";
      // 
      // acercaDeToolStripMenuItem
      // 
      this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
      this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
      this.acercaDeToolStripMenuItem.Text = "&Acerca de";
      this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
      // 
      // permutacionesToolStripMenuItem
      // 
      this.permutacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tomandoRElementosToolStripMenuItem});
      this.permutacionesToolStripMenuItem.Name = "permutacionesToolStripMenuItem";
      this.permutacionesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
      this.permutacionesToolStripMenuItem.Text = "Permutaciones";
      // 
      // tomandoRElementosToolStripMenuItem
      // 
      this.tomandoRElementosToolStripMenuItem.Name = "tomandoRElementosToolStripMenuItem";
      this.tomandoRElementosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
      this.tomandoRElementosToolStripMenuItem.Text = "Tomando r elementos";
      this.tomandoRElementosToolStripMenuItem.Click += new System.EventHandler(this.tomandoRElementosToolStripMenuItem_Click);
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(595, 371);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainWindow";
      this.Text = "FluxMath";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem electronicaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ohmToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem estadisticaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem basicoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem documentaciònToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem intercepciónToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem permutacionesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tomandoRElementosToolStripMenuItem;
  }
}

