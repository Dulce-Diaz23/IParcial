﻿namespace IParcial
{
    partial class Ejercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.OperacionesComboBox = new System.Windows.Forms.ComboBox();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(172, 32);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(121, 20);
            this.Numero1TextBox.TabIndex = 2;
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(172, 70);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(121, 20);
            this.Numero2TextBox.TabIndex = 3;
            // 
            // OperacionesComboBox
            // 
            this.OperacionesComboBox.FormattingEnabled = true;
            this.OperacionesComboBox.Items.AddRange(new object[] {
            "Sumar",
            "Restar",
            "Multiplicar",
            "Dividir"});
            this.OperacionesComboBox.Location = new System.Drawing.Point(172, 117);
            this.OperacionesComboBox.Name = "OperacionesComboBox";
            this.OperacionesComboBox.Size = new System.Drawing.Size(121, 21);
            this.OperacionesComboBox.TabIndex = 4;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(195, 156);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(75, 23);
            this.EjecutarButton.TabIndex = 5;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Location = new System.Drawing.Point(365, 76);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(55, 13);
            this.ResultadoLabel.TabIndex = 6;
            this.ResultadoLabel.Text = "Resultado";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 378);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.OperacionesComboBox);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.TextBox Numero2TextBox;
        private System.Windows.Forms.ComboBox OperacionesComboBox;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Label ResultadoLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}