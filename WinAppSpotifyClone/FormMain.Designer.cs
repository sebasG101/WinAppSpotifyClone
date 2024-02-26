namespace WinAppSpotifyClone
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarCancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cancionToolStripMenuItem
            // 
            this.cancionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCancionToolStripMenuItem,
            this.crearCancionToolStripMenuItem,
            this.actualizarCancionToolStripMenuItem,
            this.eliminarCancionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.cancionToolStripMenuItem.Name = "cancionToolStripMenuItem";
            this.cancionToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cancionToolStripMenuItem.Text = "&Cancion";
            // 
            // consultarCancionToolStripMenuItem
            // 
            this.consultarCancionToolStripMenuItem.Name = "consultarCancionToolStripMenuItem";
            this.consultarCancionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarCancionToolStripMenuItem.Text = "&Consultar cancion";
            this.consultarCancionToolStripMenuItem.Click += new System.EventHandler(this.consultarCancionToolStripMenuItem_Click);
            // 
            // crearCancionToolStripMenuItem
            // 
            this.crearCancionToolStripMenuItem.Name = "crearCancionToolStripMenuItem";
            this.crearCancionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearCancionToolStripMenuItem.Text = "C&rear cancion";
            // 
            // actualizarCancionToolStripMenuItem
            // 
            this.actualizarCancionToolStripMenuItem.Name = "actualizarCancionToolStripMenuItem";
            this.actualizarCancionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarCancionToolStripMenuItem.Text = "&Actualizar cancion";
            // 
            // eliminarCancionToolStripMenuItem
            // 
            this.eliminarCancionToolStripMenuItem.Name = "eliminarCancionToolStripMenuItem";
            this.eliminarCancionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarCancionToolStripMenuItem.Text = "&Eliminar cancion";
            this.eliminarCancionToolStripMenuItem.Click += new System.EventHandler(this.eliminarCancionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de ...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(709, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 368);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Song";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarCancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}