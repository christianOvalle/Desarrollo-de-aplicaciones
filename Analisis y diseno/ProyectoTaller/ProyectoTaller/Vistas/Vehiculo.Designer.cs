
namespace ProyectoTaller.Vistas
{
    partial class Vehiculo
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
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VehiculodataGridView = new System.Windows.Forms.DataGridView();
            this.Agregarbuttonv = new System.Windows.Forms.Button();
            this.Borrabuttonv = new System.Windows.Forms.Button();
            this.Modificarbuttonv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DueVehi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(12, 61);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(137, 20);
            this.textBoxMatricula.TabIndex = 0;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(12, 120);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(137, 20);
            this.textBoxModelo.TabIndex = 1;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(12, 174);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(137, 20);
            this.textBoxColor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color";
            // 
            // VehiculodataGridView
            // 
            this.VehiculodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculodataGridView.Location = new System.Drawing.Point(237, 61);
            this.VehiculodataGridView.Name = "VehiculodataGridView";
            this.VehiculodataGridView.Size = new System.Drawing.Size(502, 191);
            this.VehiculodataGridView.TabIndex = 8;
            this.VehiculodataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehiculodataGridView_CellDoubleClick);
            // 
            // Agregarbuttonv
            // 
            this.Agregarbuttonv.Location = new System.Drawing.Point(16, 284);
            this.Agregarbuttonv.Name = "Agregarbuttonv";
            this.Agregarbuttonv.Size = new System.Drawing.Size(75, 33);
            this.Agregarbuttonv.TabIndex = 9;
            this.Agregarbuttonv.Text = "Agregar";
            this.Agregarbuttonv.UseVisualStyleBackColor = true;
            this.Agregarbuttonv.Click += new System.EventHandler(this.Agregarbuttonv_Click_1);
            // 
            // Borrabuttonv
            // 
            this.Borrabuttonv.Location = new System.Drawing.Point(107, 284);
            this.Borrabuttonv.Name = "Borrabuttonv";
            this.Borrabuttonv.Size = new System.Drawing.Size(75, 33);
            this.Borrabuttonv.TabIndex = 10;
            this.Borrabuttonv.Text = "Borrar";
            this.Borrabuttonv.UseVisualStyleBackColor = true;
            this.Borrabuttonv.Click += new System.EventHandler(this.Borrabuttonv_Click_1);
            // 
            // Modificarbuttonv
            // 
            this.Modificarbuttonv.Location = new System.Drawing.Point(202, 284);
            this.Modificarbuttonv.Name = "Modificarbuttonv";
            this.Modificarbuttonv.Size = new System.Drawing.Size(75, 33);
            this.Modificarbuttonv.TabIndex = 11;
            this.Modificarbuttonv.Text = "Modificar";
            this.Modificarbuttonv.UseVisualStyleBackColor = true;
            this.Modificarbuttonv.Click += new System.EventHandler(this.Modificarbuttonv_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lista de vehiculos";
            // 
            // DueVehi
            // 
            this.DueVehi.FormattingEnabled = true;
            this.DueVehi.Location = new System.Drawing.Point(16, 360);
            this.DueVehi.Name = "DueVehi";
            this.DueVehi.Size = new System.Drawing.Size(153, 21);
            this.DueVehi.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Dueño del vehiculo";
            // 
            // Vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DueVehi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Modificarbuttonv);
            this.Controls.Add(this.Borrabuttonv);
            this.Controls.Add(this.Agregarbuttonv);
            this.Controls.Add(this.VehiculodataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxMatricula);
            this.Name = "Vehiculo";
            this.Text = "Vehiculo";
            this.Load += new System.EventHandler(this.Vehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehiculodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView VehiculodataGridView;
        private System.Windows.Forms.Button Agregarbuttonv;
        private System.Windows.Forms.Button Borrabuttonv;
        private System.Windows.Forms.Button Modificarbuttonv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DueVehi;
        private System.Windows.Forms.Label label4;
    }
}