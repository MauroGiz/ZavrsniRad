namespace GizdulićMauroParkingGaraža
{
    partial class Ulaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ulaz));
            this.labelTablica = new System.Windows.Forms.Label();
            this.textBoxTablica = new System.Windows.Forms.TextBox();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.timerVrijeme = new System.Windows.Forms.Timer(this.components);
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.richTextBoxIzlaz = new System.Windows.Forms.RichTextBox();
            this.printDocumentOut = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogOut = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // labelTablica
            // 
            this.labelTablica.AutoSize = true;
            this.labelTablica.Location = new System.Drawing.Point(32, 25);
            this.labelTablica.Name = "labelTablica";
            this.labelTablica.Size = new System.Drawing.Size(80, 13);
            this.labelTablica.TabIndex = 1;
            this.labelTablica.Text = "Unesite tablicu:";
            // 
            // textBoxTablica
            // 
            this.textBoxTablica.Location = new System.Drawing.Point(35, 41);
            this.textBoxTablica.Name = "textBoxTablica";
            this.textBoxTablica.Size = new System.Drawing.Size(208, 20);
            this.textBoxTablica.TabIndex = 2;
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Location = new System.Drawing.Point(101, 67);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.buttonPotvrdi.TabIndex = 3;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // timerVrijeme
            // 
            this.timerVrijeme.Enabled = true;
            this.timerVrijeme.Tick += new System.EventHandler(this.timerVrijeme_Tick);
            // 
            // labelDate
            // 
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDate.Location = new System.Drawing.Point(0, 269);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(276, 16);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelTime
            // 
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTime.Location = new System.Drawing.Point(0, 252);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(276, 17);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // richTextBoxIzlaz
            // 
            this.richTextBoxIzlaz.Location = new System.Drawing.Point(35, 96);
            this.richTextBoxIzlaz.Name = "richTextBoxIzlaz";
            this.richTextBoxIzlaz.Size = new System.Drawing.Size(208, 153);
            this.richTextBoxIzlaz.TabIndex = 6;
            this.richTextBoxIzlaz.Text = "";
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
            // Ulaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 285);
            this.Controls.Add(this.richTextBoxIzlaz);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.textBoxTablica);
            this.Controls.Add(this.labelTablica);
            this.Name = "Ulaz";
            this.Text = "Ulaz";
            this.Load += new System.EventHandler(this.Ulaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTablica;
        private System.Windows.Forms.TextBox textBoxTablica;
        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.Timer timerVrijeme;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.RichTextBox richTextBoxIzlaz;
        private System.Drawing.Printing.PrintDocument printDocumentOut;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogOut;
    }
}