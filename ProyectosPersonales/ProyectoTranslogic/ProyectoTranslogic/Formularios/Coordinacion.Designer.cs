namespace ProyectoTranslogic.Formularios
{
    partial class Coordinacion
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
            this.texboxNombreC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHoraS = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewCoordinacion = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordinacion)).BeginInit();
            this.SuspendLayout();
            // 
            // texboxNombreC
            // 
            this.texboxNombreC.Location = new System.Drawing.Point(34, 36);
            this.texboxNombreC.Name = "texboxNombreC";
            this.texboxNombreC.ReadOnly = true;
            this.texboxNombreC.Size = new System.Drawing.Size(235, 20);
            this.texboxNombreC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de evento";
            // 
            // textBoxNombreE
            // 
            this.textBoxNombreE.Location = new System.Drawing.Point(34, 87);
            this.textBoxNombreE.Name = "textBoxNombreE";
            this.textBoxNombreE.ReadOnly = true;
            this.textBoxNombreE.Size = new System.Drawing.Size(235, 20);
            this.textBoxNombreE.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora hacia evento";
            // 
            // textBoxHoraS
            // 
            this.textBoxHoraS.Location = new System.Drawing.Point(333, 36);
            this.textBoxHoraS.Name = "textBoxHoraS";
            this.textBoxHoraS.Size = new System.Drawing.Size(107, 20);
            this.textBoxHoraS.TabIndex = 5;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora hacia evento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(489, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 7;
            // 
            // dataGridViewCoordinacion
            // 
            this.dataGridViewCoordinacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoordinacion.Location = new System.Drawing.Point(34, 134);
            this.dataGridViewCoordinacion.Name = "dataGridViewCoordinacion";
            this.dataGridViewCoordinacion.Size = new System.Drawing.Size(603, 130);
            this.dataGridViewCoordinacion.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Coordinacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewCoordinacion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHoraS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombreE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texboxNombreC);
            this.Name = "Coordinacion";
            this.Text = "Coordinacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordinacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHoraS;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewCoordinacion;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox texboxNombreC;
        public System.Windows.Forms.TextBox textBoxNombreE;
    }
}