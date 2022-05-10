namespace ProyectoTaller.Vistas
{
    partial class Factura
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
            this.dataGridViewFactura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFactura
            // 
            this.dataGridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactura.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewFactura.Name = "dataGridViewFactura";
            this.dataGridViewFactura.Size = new System.Drawing.Size(530, 150);
            this.dataGridViewFactura.TabIndex = 0;
            this.dataGridViewFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFactura_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generar Factura";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFactura);
            this.Name = "Factura";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}