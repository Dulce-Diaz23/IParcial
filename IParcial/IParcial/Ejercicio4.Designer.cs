namespace IParcial
{
    partial class Ejercicio4
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
            this.components = new System.ComponentModel.Container();
            this.FechaDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DiaTextBox = new System.Windows.Forms.TextBox();
            this.AnioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SemanaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DiasTextBox = new System.Windows.Forms.TextBox();
            this.CitaTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.RestarTextBox = new System.Windows.Forms.TextBox();
            this.FechaNuevaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaDateTimePicker1
            // 
            this.FechaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker1.Location = new System.Drawing.Point(187, 44);
            this.FechaDateTimePicker1.Name = "FechaDateTimePicker1";
            this.FechaDateTimePicker1.Size = new System.Drawing.Size(109, 20);
            this.FechaDateTimePicker1.TabIndex = 0;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(341, 66);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(75, 23);
            this.EjecutarButton.TabIndex = 1;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dia:";
            // 
            // DiaTextBox
            // 
            this.DiaTextBox.Location = new System.Drawing.Point(187, 83);
            this.DiaTextBox.Name = "DiaTextBox";
            this.DiaTextBox.Size = new System.Drawing.Size(109, 20);
            this.DiaTextBox.TabIndex = 3;
            // 
            // AnioTextBox
            // 
            this.AnioTextBox.Location = new System.Drawing.Point(187, 109);
            this.AnioTextBox.Name = "AnioTextBox";
            this.AnioTextBox.Size = new System.Drawing.Size(109, 20);
            this.AnioTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anio:";
            // 
            // MesTextBox
            // 
            this.MesTextBox.Location = new System.Drawing.Point(187, 135);
            this.MesTextBox.Name = "MesTextBox";
            this.MesTextBox.Size = new System.Drawing.Size(109, 20);
            this.MesTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mes:";
            // 
            // SemanaTextBox
            // 
            this.SemanaTextBox.Location = new System.Drawing.Point(187, 161);
            this.SemanaTextBox.Name = "SemanaTextBox";
            this.SemanaTextBox.Size = new System.Drawing.Size(109, 20);
            this.SemanaTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Semana:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cita:";
            // 
            // DiasTextBox
            // 
            this.DiasTextBox.Location = new System.Drawing.Point(187, 194);
            this.DiasTextBox.Name = "DiasTextBox";
            this.DiasTextBox.Size = new System.Drawing.Size(109, 20);
            this.DiasTextBox.TabIndex = 11;
            // 
            // CitaTextBox
            // 
            this.CitaTextBox.Location = new System.Drawing.Point(307, 194);
            this.CitaTextBox.Name = "CitaTextBox";
            this.CitaTextBox.ReadOnly = true;
            this.CitaTextBox.Size = new System.Drawing.Size(109, 20);
            this.CitaTextBox.TabIndex = 13;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Restar Dias:";
            // 
            // RestarTextBox
            // 
            this.RestarTextBox.Location = new System.Drawing.Point(187, 230);
            this.RestarTextBox.Name = "RestarTextBox";
            this.RestarTextBox.Size = new System.Drawing.Size(109, 20);
            this.RestarTextBox.TabIndex = 14;
            // 
            // FechaNuevaTextBox
            // 
            this.FechaNuevaTextBox.Location = new System.Drawing.Point(307, 230);
            this.FechaNuevaTextBox.Name = "FechaNuevaTextBox";
            this.FechaNuevaTextBox.ReadOnly = true;
            this.FechaNuevaTextBox.Size = new System.Drawing.Size(229, 20);
            this.FechaNuevaTextBox.TabIndex = 16;
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FechaNuevaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RestarTextBox);
            this.Controls.Add(this.CitaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DiasTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SemanaTextBox);
            this.Controls.Add(this.MesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.FechaDateTimePicker1);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaDateTimePicker1;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiaTextBox;
        private System.Windows.Forms.TextBox AnioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SemanaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DiasTextBox;
        private System.Windows.Forms.TextBox CitaTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RestarTextBox;
        private System.Windows.Forms.TextBox FechaNuevaTextBox;
    }
}