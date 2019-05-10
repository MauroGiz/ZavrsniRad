namespace GizdulićMauroParkingGaraža
{
    partial class PotvrdaAdministratora
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
            this.labelAdministrator = new System.Windows.Forms.Label();
            this.labelSifra = new System.Windows.Forms.Label();
            this.textBoxAdministrator = new System.Windows.Forms.TextBox();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.buttonIzadi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdministrator
            // 
            this.labelAdministrator.AutoSize = true;
            this.labelAdministrator.Location = new System.Drawing.Point(37, 31);
            this.labelAdministrator.Name = "labelAdministrator";
            this.labelAdministrator.Size = new System.Drawing.Size(70, 13);
            this.labelAdministrator.TabIndex = 0;
            this.labelAdministrator.Text = "Administrator:";
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Location = new System.Drawing.Point(37, 72);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(31, 13);
            this.labelSifra.TabIndex = 1;
            this.labelSifra.Text = "Šifra:";
            // 
            // textBoxAdministrator
            // 
            this.textBoxAdministrator.Location = new System.Drawing.Point(129, 28);
            this.textBoxAdministrator.Name = "textBoxAdministrator";
            this.textBoxAdministrator.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdministrator.TabIndex = 0;
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(130, 69);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(100, 20);
            this.textBoxSifra.TabIndex = 1;
            this.textBoxSifra.UseSystemPasswordChar = true;
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Location = new System.Drawing.Point(40, 119);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.buttonPotvrdi.TabIndex = 2;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // buttonIzadi
            // 
            this.buttonIzadi.Location = new System.Drawing.Point(154, 119);
            this.buttonIzadi.Name = "buttonIzadi";
            this.buttonIzadi.Size = new System.Drawing.Size(75, 23);
            this.buttonIzadi.TabIndex = 3;
            this.buttonIzadi.Text = "Izađi";
            this.buttonIzadi.UseVisualStyleBackColor = true;
            this.buttonIzadi.Click += new System.EventHandler(this.buttonIzadi_Click);
            // 
            // PotvrdaAdministratora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 167);
            this.Controls.Add(this.buttonIzadi);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.textBoxSifra);
            this.Controls.Add(this.textBoxAdministrator);
            this.Controls.Add(this.labelSifra);
            this.Controls.Add(this.labelAdministrator);
            this.MaximizeBox = false;
            this.Name = "PotvrdaAdministratora";
            this.Text = "PotvrdaAdministratora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdministrator;
        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.TextBox textBoxAdministrator;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.Button buttonIzadi;
    }
}