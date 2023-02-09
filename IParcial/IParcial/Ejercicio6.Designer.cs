namespace IParcial
{
    partial class Ejercicio6
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
            this.ArreglosListBox = new System.Windows.Forms.ListBox();
            this.ArregloButton = new System.Windows.Forms.Button();
            this.ArreglosComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ArreglosListBox
            // 
            this.ArreglosListBox.FormattingEnabled = true;
            this.ArreglosListBox.Location = new System.Drawing.Point(74, 28);
            this.ArreglosListBox.Name = "ArreglosListBox";
            this.ArreglosListBox.Size = new System.Drawing.Size(120, 95);
            this.ArreglosListBox.TabIndex = 0;
            // 
            // ArregloButton
            // 
            this.ArregloButton.Location = new System.Drawing.Point(259, 74);
            this.ArregloButton.Name = "ArregloButton";
            this.ArregloButton.Size = new System.Drawing.Size(90, 30);
            this.ArregloButton.TabIndex = 1;
            this.ArregloButton.Text = "Arreglo";
            this.ArregloButton.UseVisualStyleBackColor = true;
            this.ArregloButton.Click += new System.EventHandler(this.ArregloButton_Click);
            // 
            // ArreglosComboBox
            // 
            this.ArreglosComboBox.FormattingEnabled = true;
            this.ArreglosComboBox.Location = new System.Drawing.Point(74, 146);
            this.ArreglosComboBox.Name = "ArreglosComboBox";
            this.ArreglosComboBox.Size = new System.Drawing.Size(121, 21);
            this.ArreglosComboBox.TabIndex = 2;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 299);
            this.Controls.Add(this.ArreglosComboBox);
            this.Controls.Add(this.ArregloButton);
            this.Controls.Add(this.ArreglosListBox);
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ArreglosListBox;
        private System.Windows.Forms.Button ArregloButton;
        private System.Windows.Forms.ComboBox ArreglosComboBox;
    }
}