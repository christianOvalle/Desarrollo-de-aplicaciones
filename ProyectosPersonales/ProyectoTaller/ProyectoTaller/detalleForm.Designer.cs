
namespace ProyectoTaller
{
    partial class detalleForm
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
            this.matriculaVehiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idCliente = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.piezaRepuesto = new System.Windows.Forms.ComboBox();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.manoObra = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Borrarbutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.precioPieza = new System.Windows.Forms.NumericUpDown();
            this.precioManoObra = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.idCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioPieza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioManoObra)).BeginInit();
            this.SuspendLayout();
            // 
            // matriculaVehiculo
            // 
            this.matriculaVehiculo.FormattingEnabled = true;
            this.matriculaVehiculo.Location = new System.Drawing.Point(12, 81);
            this.matriculaVehiculo.Name = "matriculaVehiculo";
            this.matriculaVehiculo.Size = new System.Drawing.Size(153, 21);
            this.matriculaVehiculo.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Matricula vehiculo";
            // 
            // idCliente
            // 
            this.idCliente.Location = new System.Drawing.Point(12, 30);
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Size = new System.Drawing.Size(91, 20);
            this.idCliente.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Pieza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Mano de obra";
            // 
            // piezaRepuesto
            // 
            this.piezaRepuesto.FormattingEnabled = true;
            this.piezaRepuesto.Location = new System.Drawing.Point(14, 131);
            this.piezaRepuesto.Name = "piezaRepuesto";
            this.piezaRepuesto.Size = new System.Drawing.Size(153, 21);
            this.piezaRepuesto.TabIndex = 52;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(16, 185);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(87, 20);
            this.cantidad.TabIndex = 53;
            // 
            // manoObra
            // 
            this.manoObra.FormattingEnabled = true;
            this.manoObra.Location = new System.Drawing.Point(13, 235);
            this.manoObra.Name = "manoObra";
            this.manoObra.Size = new System.Drawing.Size(153, 21);
            this.manoObra.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 150);
            this.dataGridView1.TabIndex = 55;
            // 
            // Borrarbutton
            // 
            this.Borrarbutton.Location = new System.Drawing.Point(237, 430);
            this.Borrarbutton.Name = "Borrarbutton";
            this.Borrarbutton.Size = new System.Drawing.Size(80, 30);
            this.Borrarbutton.TabIndex = 58;
            this.Borrarbutton.Text = "Borrar";
            this.Borrarbutton.UseVisualStyleBackColor = true;
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(123, 430);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(87, 30);
            this.Modificarbutton.TabIndex = 57;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(13, 429);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(88, 28);
            this.Agregarbutton.TabIndex = 56;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // precioPieza
            // 
            this.precioPieza.Location = new System.Drawing.Point(518, 30);
            this.precioPieza.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.precioPieza.Name = "precioPieza";
            this.precioPieza.Size = new System.Drawing.Size(87, 20);
            this.precioPieza.TabIndex = 60;
            this.precioPieza.Visible = false;
            // 
            // precioManoObra
            // 
            this.precioManoObra.Location = new System.Drawing.Point(518, 56);
            this.precioManoObra.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.precioManoObra.Name = "precioManoObra";
            this.precioManoObra.Size = new System.Drawing.Size(87, 20);
            this.precioManoObra.TabIndex = 61;
            this.precioManoObra.Visible = false;
            // 
            // detalleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 536);
            this.Controls.Add(this.precioManoObra);
            this.Controls.Add(this.precioPieza);
            this.Controls.Add(this.Borrarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.manoObra);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.piezaRepuesto);
            this.Controls.Add(this.matriculaVehiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "detalleForm";
            this.Text = "detalleForm";
            this.Load += new System.EventHandler(this.detalleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioPieza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioManoObra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox matriculaVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown idCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox piezaRepuesto;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.ComboBox manoObra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Borrarbutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.NumericUpDown precioPieza;
        private System.Windows.Forms.NumericUpDown precioManoObra;
    }
}