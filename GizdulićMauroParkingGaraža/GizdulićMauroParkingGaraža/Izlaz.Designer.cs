namespace GizdulićMauroParkingGaraža
{
    partial class Izlaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Izlaz));
            this.labelKod = new System.Windows.Forms.Label();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.richTextBoxIzlaz = new System.Windows.Forms.RichTextBox();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.printDocumentOut = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogOut = new System.Windows.Forms.PrintPreviewDialog();
            this.buttonCijena = new System.Windows.Forms.Button();
            this.textBoxUnosCijene = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.Location = new System.Drawing.Point(39, 25);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(67, 13);
            this.labelKod.TabIndex = 0;
            this.labelKod.Text = "Unesite kod:";
            // 
            // textBoxKod
            // 
            this.textBoxKod.Location = new System.Drawing.Point(42, 41);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(285, 20);
            this.textBoxKod.TabIndex = 1;
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Location = new System.Drawing.Point(149, 67);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.buttonPotvrdi.TabIndex = 2;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // richTextBoxIzlaz
            // 
            this.richTextBoxIzlaz.Location = new System.Drawing.Point(42, 130);
            this.richTextBoxIzlaz.Name = "richTextBoxIzlaz";
            this.richTextBoxIzlaz.Size = new System.Drawing.Size(285, 189);
            this.richTextBoxIzlaz.TabIndex = 3;
            this.richTextBoxIzlaz.Text = "";
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(149, 405);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvori.TabIndex = 4;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // printDocumentOut
            // 
            this.printDocumentOut.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentOut_PrintPage);
            // 
            // printPreviewDialogOut
            // 
            this.printPreviewDialogOut.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogOut.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogOut.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogOut.Enabled = true;
            this.printPreviewDialogOut.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogOut.Icon")));
            this.printPreviewDialogOut.Name = "printPreviewDialogOut";
            this.printPreviewDialogOut.Visible = false;
            // 
            // buttonCijena
            // 
            this.buttonCijena.Enabled = false;
            this.buttonCijena.Location = new System.Drawing.Point(149, 376);
            this.buttonCijena.Name = "buttonCijena";
            this.buttonCijena.Size = new System.Drawing.Size(75, 23);
            this.buttonCijena.TabIndex = 5;
            this.buttonCijena.Text = "Unos cijene";
            this.buttonCijena.UseVisualStyleBackColor = true;
            this.buttonCijena.Click += new System.EventHandler(this.buttonCijena_Click);
            // 
            // textBoxUnosCijene
            // 
            this.textBoxUnosCijene.Enabled = false;
            this.textBoxUnosCijene.Location = new System.Drawing.Point(42, 350);
            this.textBoxUnosCijene.Name = "textBoxUnosCijene";
            this.textBoxUnosCijene.Size = new System.Drawing.Size(285, 20);
            this.textBoxUnosCijene.TabIndex = 6;
            // 
            // Izlaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 440);
            this.Controls.Add(this.textBoxUnosCijene);
            this.Controls.Add(this.buttonCijena);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.richTextBoxIzlaz);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.textBoxKod);
            this.Controls.Add(this.labelKod);
            this.MaximizeBox = false;
            this.Name = "Izlaz";
            this.Text = "Izlaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.RichTextBox richTextBoxIzlaz;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Drawing.Printing.PrintDocument printDocumentOut;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogOut;
        private System.Windows.Forms.Button buttonCijena;
        private System.Windows.Forms.TextBox textBoxUnosCijene;
    }
}