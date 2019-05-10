namespace GizdulićMauroParkingGaraža.Informacije
{
    partial class Cijene
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
            this.labelNaslov = new System.Windows.Forms.Label();
            this.labelCijenovnik = new System.Windows.Forms.Label();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaslov.Location = new System.Drawing.Point(0, 0);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(434, 41);
            this.labelNaslov.TabIndex = 0;
            this.labelNaslov.Text = "Cijene";
            this.labelNaslov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCijenovnik
            // 
            this.labelCijenovnik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCijenovnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCijenovnik.Location = new System.Drawing.Point(0, 41);
            this.labelCijenovnik.Name = "labelCijenovnik";
            this.labelCijenovnik.Size = new System.Drawing.Size(434, 247);
            this.labelCijenovnik.TabIndex = 1;
            this.labelCijenovnik.Text = "Prvih sat vremena je besplatno!\r\n\r\nSvaki sljedeći sat iznosi 5 kn!\r\n\r\nCijena za c" +
    "ijeli dan je 60 kn!\r\n\r\nCijeli dan se podrazumijeva više od 8 sati provedenih na " +
    "parkingu!\r\n\r\n";
            this.labelCijenovnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(183, 253);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvori.TabIndex = 0;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // Cijene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 288);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.labelCijenovnik);
            this.Controls.Add(this.labelNaslov);
            this.MaximizeBox = false;
            this.Name = "Cijene";
            this.Text = "Cijene";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label labelCijenovnik;
        private System.Windows.Forms.Button buttonZatvori;
    }
}