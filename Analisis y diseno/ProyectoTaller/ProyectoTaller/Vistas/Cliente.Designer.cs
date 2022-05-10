namespace ProyectoTaller.Vistas
{
    partial class Cliente
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
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ApellidotextBox = new System.Windows.Forms.TextBox();
            this.CedulatextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.TelefonotextBox = new System.Windows.Forms.TextBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ClientesdataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Borrarbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idCliente = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(12, 83);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(309, 20);
            this.NombretextBox.TabIndex = 0;
            // 
            // ApellidotextBox
            // 
            this.ApellidotextBox.Location = new System.Drawing.Point(12, 131);
            this.ApellidotextBox.Name = "ApellidotextBox";
            this.ApellidotextBox.Size = new System.Drawing.Size(248, 20);
            this.ApellidotextBox.TabIndex = 1;
            // 
            // CedulatextBox
            // 
            this.CedulatextBox.Location = new System.Drawing.Point(14, 173);
            this.CedulatextBox.Name = "CedulatextBox";
            this.CedulatextBox.Size = new System.Drawing.Size(153, 20);
            this.CedulatextBox.TabIndex = 2;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(14, 215);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(357, 20);
            this.DirecciontextBox.TabIndex = 3;
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.Location = new System.Drawing.Point(14, 259);
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.Size = new System.Drawing.Size(153, 20);
            this.TelefonotextBox.TabIndex = 4;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(15, 299);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(88, 28);
            this.Agregarbutton.TabIndex = 5;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cedula";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Direccion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Telefono";
            // 
            // ClientesdataGridView
            // 
            this.ClientesdataGridView.AllowUserToAddRows = false;
            this.ClientesdataGridView.AllowUserToDeleteRows = false;
            this.ClientesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesdataGridView.Location = new System.Drawing.Point(409, 40);
            this.ClientesdataGridView.Name = "ClientesdataGridView";
            this.ClientesdataGridView.ReadOnly = true;
            this.ClientesdataGridView.Size = new System.Drawing.Size(514, 253);
            this.ClientesdataGridView.TabIndex = 17;
            this.ClientesdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RellenarCampos);
            this.ClientesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesdataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lista de clientes";
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(125, 300);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(87, 30);
            this.Modificarbutton.TabIndex = 19;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // Borrarbutton
            // 
            this.Borrarbutton.Location = new System.Drawing.Point(239, 300);
            this.Borrarbutton.Name = "Borrarbutton";
            this.Borrarbutton.Size = new System.Drawing.Size(80, 30);
            this.Borrarbutton.TabIndex = 22;
            this.Borrarbutton.Text = "Borrar";
            this.Borrarbutton.UseVisualStyleBackColor = true;
            this.Borrarbutton.Click += new System.EventHandler(this.Borrarbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 53);
            this.button1.TabIndex = 25;
            this.button1.Text = "Agregar Vehiculo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Id";
            // 
            // idCliente
            // 
            this.idCliente.Location = new System.Drawing.Point(12, 25);
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Size = new System.Drawing.Size(91, 20);
            this.idCliente.TabIndex = 27;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.idCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Borrarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientesdataGridView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.TelefonotextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.CedulatextBox);
            this.Controls.Add(this.ApellidotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox ApellidotextBox;
        private System.Windows.Forms.TextBox CedulatextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox TelefonotextBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView ClientesdataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Borrarbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown idCliente;
    }
}