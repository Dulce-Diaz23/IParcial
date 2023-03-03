namespace IParcial
{
    partial class Ejercicio9
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
            this.Agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MarcaTextBox = new System.Windows.Forms.TextBox();
            this.ModeloTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.KilometrosTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CochesDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CochesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(294, 103);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(93, 35);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kilometros:";
            // 
            // MarcaTextBox
            // 
            this.MarcaTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.MarcaTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MarcaTextBox.Location = new System.Drawing.Point(123, 49);
            this.MarcaTextBox.Name = "MarcaTextBox";
            this.MarcaTextBox.Size = new System.Drawing.Size(100, 20);
            this.MarcaTextBox.TabIndex = 5;
            // 
            // ModeloTextBox
            // 
            this.ModeloTextBox.Location = new System.Drawing.Point(123, 85);
            this.ModeloTextBox.Name = "ModeloTextBox";
            this.ModeloTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModeloTextBox.TabIndex = 6;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(123, 122);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioTextBox.TabIndex = 7;
            // 
            // KilometrosTextBox
            // 
            this.KilometrosTextBox.Location = new System.Drawing.Point(123, 160);
            this.KilometrosTextBox.Name = "KilometrosTextBox";
            this.KilometrosTextBox.Size = new System.Drawing.Size(100, 20);
            this.KilometrosTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marca:";
            // 
            // CochesDataGridView
            // 
            this.CochesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CochesDataGridView.Location = new System.Drawing.Point(3, 228);
            this.CochesDataGridView.Name = "CochesDataGridView";
            this.CochesDataGridView.Size = new System.Drawing.Size(610, 150);
            this.CochesDataGridView.TabIndex = 10;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Ejercicio9
            // 
            this.AcceptButton = this.Agregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 374);
            this.Controls.Add(this.CochesDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KilometrosTextBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.ModeloTextBox);
            this.Controls.Add(this.MarcaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Agregar);
            this.Name = "Ejercicio9";
            this.Text = "Ejercicio9cs";
            ((System.ComponentModel.ISupportInitialize)(this.CochesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MarcaTextBox;
        private System.Windows.Forms.TextBox ModeloTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox KilometrosTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CochesDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}