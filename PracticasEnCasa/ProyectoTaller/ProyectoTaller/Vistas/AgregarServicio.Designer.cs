namespace ProyectoTaller.Vistas
{
    partial class AgregarServicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTiposerv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericCosto = new System.Windows.Forms.NumericUpDown();
            this.buttonaddserv = new System.Windows.Forms.Button();
            this.buttoneditserv = new System.Windows.Forms.Button();
            this.buttondeleteserv = new System.Windows.Forms.Button();
            this.dataGridViewServicios = new System.Windows.Forms.DataGridView();
            this.numericid = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de servicio";
            // 
            // textBoxTiposerv
            // 
            this.textBoxTiposerv.Location = new System.Drawing.Point(16, 62);
            this.textBoxTiposerv.Name = "textBoxTiposerv";
            this.textBoxTiposerv.Size = new System.Drawing.Size(332, 20);
            this.textBoxTiposerv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Costo";
            // 
            // numericCosto
            // 
            this.numericCosto.Location = new System.Drawing.Point(16, 121);
            this.numericCosto.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericCosto.Name = "numericCosto";
            this.numericCosto.Size = new System.Drawing.Size(103, 20);
            this.numericCosto.TabIndex = 4;
            // 
            // buttonaddserv
            // 
            this.buttonaddserv.Location = new System.Drawing.Point(19, 178);
            this.buttonaddserv.Name = "buttonaddserv";
            this.buttonaddserv.Size = new System.Drawing.Size(75, 23);
            this.buttonaddserv.TabIndex = 5;
            this.buttonaddserv.Text = "Agregar";
            this.buttonaddserv.UseVisualStyleBackColor = true;
            this.buttonaddserv.Click += new System.EventHandler(this.buttonaddserv_Click);
            // 
            // buttoneditserv
            // 
            this.buttoneditserv.Location = new System.Drawing.Point(119, 178);
            this.buttoneditserv.Name = "buttoneditserv";
            this.buttoneditserv.Size = new System.Drawing.Size(75, 23);
            this.buttoneditserv.TabIndex = 6;
            this.buttoneditserv.Text = "Editar";
            this.buttoneditserv.UseVisualStyleBackColor = true;
            this.buttoneditserv.Click += new System.EventHandler(this.buttoneditserv_Click);
            // 
            // buttondeleteserv
            // 
            this.buttondeleteserv.Location = new System.Drawing.Point(223, 178);
            this.buttondeleteserv.Name = "buttondeleteserv";
            this.buttondeleteserv.Size = new System.Drawing.Size(75, 23);
            this.buttondeleteserv.TabIndex = 7;
            this.buttondeleteserv.Text = "Borrar";
            this.buttondeleteserv.UseVisualStyleBackColor = true;
            this.buttondeleteserv.Click += new System.EventHandler(this.buttondeleteserv_Click);
            // 
            // dataGridViewServicios
            // 
            this.dataGridViewServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicios.Location = new System.Drawing.Point(16, 241);
            this.dataGridViewServicios.Name = "dataGridViewServicios";
            this.dataGridViewServicios.Size = new System.Drawing.Size(300, 150);
            this.dataGridViewServicios.TabIndex = 8;
            this.dataGridViewServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.llenar);
            // 
            // numericid
            // 
            this.numericid.Location = new System.Drawing.Point(269, 12);
            this.numericid.Name = "numericid";
            this.numericid.ReadOnly = true;
            this.numericid.Size = new System.Drawing.Size(66, 20);
            this.numericid.TabIndex = 9;
            this.numericid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "id";
            // 
            // AgregarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericid);
            this.Controls.Add(this.dataGridViewServicios);
            this.Controls.Add(this.buttondeleteserv);
            this.Controls.Add(this.buttoneditserv);
            this.Controls.Add(this.buttonaddserv);
            this.Controls.Add(this.numericCosto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTiposerv);
            this.Controls.Add(this.label1);
            this.Name = "AgregarServicio";
            this.Text = "AgregarServicio";
            ((System.ComponentModel.ISupportInitialize)(this.numericCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTiposerv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericCosto;
        private System.Windows.Forms.Button buttonaddserv;
        private System.Windows.Forms.Button buttoneditserv;
        private System.Windows.Forms.Button buttondeleteserv;
        private System.Windows.Forms.DataGridView dataGridViewServicios;
        private System.Windows.Forms.NumericUpDown numericid;
        private System.Windows.Forms.Label label3;
    }
}