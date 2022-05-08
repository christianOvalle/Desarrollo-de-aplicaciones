
namespace ProyectoTaller.Vistas
{
    partial class Piezas
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
            this.textBoxnombrepieza = new System.Windows.Forms.TextBox();
            this.textBoxpreciodepieza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxcantidaddisponible = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonusada = new System.Windows.Forms.RadioButton();
            this.radioButtonnueva = new System.Windows.Forms.RadioButton();
            this.dataGridViewHerramientas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPiezaadd = new System.Windows.Forms.Button();
            this.buttoneditpiezza = new System.Windows.Forms.Button();
            this.buttondeletepiezza = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de pieza";
            // 
            // textBoxnombrepieza
            // 
            this.textBoxnombrepieza.Location = new System.Drawing.Point(24, 55);
            this.textBoxnombrepieza.Name = "textBoxnombrepieza";
            this.textBoxnombrepieza.Size = new System.Drawing.Size(284, 20);
            this.textBoxnombrepieza.TabIndex = 1;
            // 
            // textBoxpreciodepieza
            // 
            this.textBoxpreciodepieza.Location = new System.Drawing.Point(24, 124);
            this.textBoxpreciodepieza.Name = "textBoxpreciodepieza";
            this.textBoxpreciodepieza.Size = new System.Drawing.Size(123, 20);
            this.textBoxpreciodepieza.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio de pieza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad disponible";
            // 
            // textBoxcantidaddisponible
            // 
            this.textBoxcantidaddisponible.Location = new System.Drawing.Point(25, 205);
            this.textBoxcantidaddisponible.Name = "textBoxcantidaddisponible";
            this.textBoxcantidaddisponible.Size = new System.Drawing.Size(143, 20);
            this.textBoxcantidaddisponible.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado de pieza";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonusada);
            this.panel1.Controls.Add(this.radioButtonnueva);
            this.panel1.Location = new System.Drawing.Point(24, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 52);
            this.panel1.TabIndex = 9;
            // 
            // radioButtonusada
            // 
            this.radioButtonusada.AutoSize = true;
            this.radioButtonusada.Location = new System.Drawing.Point(94, 15);
            this.radioButtonusada.Name = "radioButtonusada";
            this.radioButtonusada.Size = new System.Drawing.Size(56, 17);
            this.radioButtonusada.TabIndex = 1;
            this.radioButtonusada.TabStop = true;
            this.radioButtonusada.Text = "Usada";
            this.radioButtonusada.UseVisualStyleBackColor = true;
            // 
            // radioButtonnueva
            // 
            this.radioButtonnueva.AutoSize = true;
            this.radioButtonnueva.Location = new System.Drawing.Point(7, 15);
            this.radioButtonnueva.Name = "radioButtonnueva";
            this.radioButtonnueva.Size = new System.Drawing.Size(57, 17);
            this.radioButtonnueva.TabIndex = 0;
            this.radioButtonnueva.TabStop = true;
            this.radioButtonnueva.Text = "Nueva";
            this.radioButtonnueva.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHerramientas
            // 
            this.dataGridViewHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHerramientas.Location = new System.Drawing.Point(326, 42);
            this.dataGridViewHerramientas.Name = "dataGridViewHerramientas";
            this.dataGridViewHerramientas.Size = new System.Drawing.Size(634, 263);
            this.dataGridViewHerramientas.TabIndex = 10;
            this.dataGridViewHerramientas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHerramientas_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lista de Herramientas";
            // 
            // buttonPiezaadd
            // 
            this.buttonPiezaadd.Location = new System.Drawing.Point(326, 364);
            this.buttonPiezaadd.Name = "buttonPiezaadd";
            this.buttonPiezaadd.Size = new System.Drawing.Size(97, 38);
            this.buttonPiezaadd.TabIndex = 12;
            this.buttonPiezaadd.Text = "Agregar pieza";
            this.buttonPiezaadd.UseVisualStyleBackColor = true;
            this.buttonPiezaadd.Click += new System.EventHandler(this.buttonPiezaadd_Click);
            // 
            // buttoneditpiezza
            // 
            this.buttoneditpiezza.Location = new System.Drawing.Point(532, 364);
            this.buttoneditpiezza.Name = "buttoneditpiezza";
            this.buttoneditpiezza.Size = new System.Drawing.Size(97, 38);
            this.buttoneditpiezza.TabIndex = 13;
            this.buttoneditpiezza.Text = "Editar pieza";
            this.buttoneditpiezza.UseVisualStyleBackColor = true;
            this.buttoneditpiezza.Click += new System.EventHandler(this.buttoneditpiezza_Click);
            // 
            // buttondeletepiezza
            // 
            this.buttondeletepiezza.Location = new System.Drawing.Point(736, 364);
            this.buttondeletepiezza.Name = "buttondeletepiezza";
            this.buttondeletepiezza.Size = new System.Drawing.Size(97, 38);
            this.buttondeletepiezza.TabIndex = 14;
            this.buttondeletepiezza.Text = "Borrar pieza";
            this.buttondeletepiezza.UseVisualStyleBackColor = true;
            this.buttondeletepiezza.Click += new System.EventHandler(this.buttondeletepiezza_Click);
            // 
            // Piezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.buttondeletepiezza);
            this.Controls.Add(this.buttoneditpiezza);
            this.Controls.Add(this.buttonPiezaadd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewHerramientas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxcantidaddisponible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxpreciodepieza);
            this.Controls.Add(this.textBoxnombrepieza);
            this.Controls.Add(this.label1);
            this.Name = "Piezas";
            this.Text = "Piezas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnombrepieza;
        private System.Windows.Forms.TextBox textBoxpreciodepieza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxcantidaddisponible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonusada;
        private System.Windows.Forms.RadioButton radioButtonnueva;
        private System.Windows.Forms.DataGridView dataGridViewHerramientas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonPiezaadd;
        private System.Windows.Forms.Button buttoneditpiezza;
        private System.Windows.Forms.Button buttondeletepiezza;
    }
}