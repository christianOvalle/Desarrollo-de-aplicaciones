
namespace MostrarImagen
{
    partial class Taza_de_Cambio
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
            this.dolarAPesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesoADolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euroAPesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesoAEuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dolarAPesoToolStripMenuItem,
            this.pesoADolarToolStripMenuItem,
            this.euroAPesoToolStripMenuItem,
            this.pesoAEuroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dolarAPesoToolStripMenuItem
            // 
            this.dolarAPesoToolStripMenuItem.Name = "dolarAPesoToolStripMenuItem";
            this.dolarAPesoToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.dolarAPesoToolStripMenuItem.Text = "Dolar a Peso";
            this.dolarAPesoToolStripMenuItem.Click += new System.EventHandler(this.dolarAPesoToolStripMenuItem_Click);
            // 
            // pesoADolarToolStripMenuItem
            // 
            this.pesoADolarToolStripMenuItem.Name = "pesoADolarToolStripMenuItem";
            this.pesoADolarToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.pesoADolarToolStripMenuItem.Text = "Peso  a Dolar";
            this.pesoADolarToolStripMenuItem.Click += new System.EventHandler(this.pesoADolarToolStripMenuItem_Click);
            // 
            // euroAPesoToolStripMenuItem
            // 
            this.euroAPesoToolStripMenuItem.Name = "euroAPesoToolStripMenuItem";
            this.euroAPesoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.euroAPesoToolStripMenuItem.Text = "Euro a peso";
            // 
            // pesoAEuroToolStripMenuItem
            // 
            this.pesoAEuroToolStripMenuItem.Name = "pesoAEuroToolStripMenuItem";
            this.pesoAEuroToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.pesoAEuroToolStripMenuItem.Text = "Peso  a Euro";
            // 
            // Taza_de_Cambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Taza_de_Cambio";
            this.Text = "Taza_de_Cambio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dolarAPesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesoADolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem euroAPesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesoAEuroToolStripMenuItem;
    }
}