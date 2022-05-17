namespace ProyectoTranslogic.Formularios
{
    partial class CompaniasRegistros
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
            this.texboxNombreC = new System.Windows.Forms.TextBox();
            this.dataGridViewCompa = new System.Windows.Forms.DataGridView();
            this.buttonadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRNC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de compañia";
            // 
            // texboxNombreC
            // 
            this.texboxNombreC.Location = new System.Drawing.Point(32, 63);
            this.texboxNombreC.Name = "texboxNombreC";
            this.texboxNombreC.Size = new System.Drawing.Size(221, 20);
            this.texboxNombreC.TabIndex = 1;
            // 
            // dataGridViewCompa
            // 
            this.dataGridViewCompa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompa.Location = new System.Drawing.Point(335, 31);
            this.dataGridViewCompa.Name = "dataGridViewCompa";
            this.dataGridViewCompa.Size = new System.Drawing.Size(396, 150);
            this.dataGridViewCompa.TabIndex = 2;
            this.dataGridViewCompa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LlenarCampos);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(36, 283);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 43);
            this.buttonadd.TabIndex = 3;
            this.buttonadd.Text = "Agregar";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "RNC de compañia";
            // 
            // textBoxRNC
            // 
            this.textBoxRNC.Location = new System.Drawing.Point(32, 145);
            this.textBoxRNC.Name = "textBoxRNC";
            this.textBoxRNC.Size = new System.Drawing.Size(221, 20);
            this.textBoxRNC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direccion";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(34, 233);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(383, 20);
            this.textBoxDireccion.TabIndex = 7;
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(169, 283);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 43);
            this.buttondelete.TabIndex = 8;
            this.buttondelete.Text = "Borrar";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(311, 283);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 43);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // CompañiasRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRNC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.dataGridViewCompa);
            this.Controls.Add(this.texboxNombreC);
            this.Controls.Add(this.label1);
            this.Name = "CompañiasRegistros";
            this.Text = "CompañiasRegistros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texboxNombreC;
        private System.Windows.Forms.DataGridView dataGridViewCompa;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonEditar;
    }
}