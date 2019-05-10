namespace GizdulićMauroParkingGaraža.OGarazi
{
    partial class UPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UPU));
            this.labelUPU = new System.Windows.Forms.Label();
            this.labelTekst = new System.Windows.Forms.Label();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUPU
            // 
            this.labelUPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUPU.Location = new System.Drawing.Point(0, 0);
            this.labelUPU.Name = "labelUPU";
            this.labelUPU.Size = new System.Drawing.Size(643, 42);
            this.labelUPU.TabIndex = 0;
            this.labelUPU.Text = "Uvjeti pružanja usluge";
            this.labelUPU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTekst
            // 
            this.labelTekst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTekst.Location = new System.Drawing.Point(0, 42);
            this.labelTekst.Name = "labelTekst";
            this.labelTekst.Size = new System.Drawing.Size(643, 313);
            this.labelTekst.TabIndex = 1;
            this.labelTekst.Text = resources.GetString("labelTekst.Text");
            this.labelTekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(284, 320);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvori.TabIndex = 0;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // UPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 355);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.labelTekst);
            this.Controls.Add(this.labelUPU);
            this.MaximizeBox = false;
            this.Name = "UPU";
            this.Text = "UPU";
            this.Load += new System.EventHandler(this.UPU_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUPU;
        private System.Windows.Forms.Label labelTekst;
        private System.Windows.Forms.Button buttonZatvori;
    }
}