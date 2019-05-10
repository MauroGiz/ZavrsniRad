namespace GizdulićMauroParkingGaraža
{
    partial class FormParkingGaraza
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
            this.labelNaslov = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oGaražiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uvjetiPružanjaUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radnoVrijemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izgledMapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cijeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonUlaz = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonIzlaz = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerVrijeme = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaslov.Location = new System.Drawing.Point(0, 24);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(487, 48);
            this.labelNaslov.TabIndex = 0;
            this.labelNaslov.Text = "Parking garaža - Mauro";
            this.labelNaslov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelNaslov.Click += new System.EventHandler(this.labelNaslov_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oGaražiToolStripMenuItem,
            this.informacijeToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.administratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oGaražiToolStripMenuItem
            // 
            this.oGaražiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNamaToolStripMenuItem,
            this.uvjetiPružanjaUslugeToolStripMenuItem});
            this.oGaražiToolStripMenuItem.Name = "oGaražiToolStripMenuItem";
            this.oGaražiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.oGaražiToolStripMenuItem.Text = "O garaži";
            // 
            // oNamaToolStripMenuItem
            // 
            this.oNamaToolStripMenuItem.Name = "oNamaToolStripMenuItem";
            this.oNamaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.oNamaToolStripMenuItem.Text = "O nama";
            this.oNamaToolStripMenuItem.Click += new System.EventHandler(this.oNamaToolStripMenuItem_Click);
            // 
            // uvjetiPružanjaUslugeToolStripMenuItem
            // 
            this.uvjetiPružanjaUslugeToolStripMenuItem.Name = "uvjetiPružanjaUslugeToolStripMenuItem";
            this.uvjetiPružanjaUslugeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.uvjetiPružanjaUslugeToolStripMenuItem.Text = "Uvjeti pružanja usluge";
            this.uvjetiPružanjaUslugeToolStripMenuItem.Click += new System.EventHandler(this.uvjetiPružanjaUslugeToolStripMenuItem_Click);
            // 
            // informacijeToolStripMenuItem
            // 
            this.informacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radnoVrijemeToolStripMenuItem,
            this.izgledMapeToolStripMenuItem,
            this.cijeneToolStripMenuItem});
            this.informacijeToolStripMenuItem.Name = "informacijeToolStripMenuItem";
            this.informacijeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.informacijeToolStripMenuItem.Text = "Informacije";
            // 
            // radnoVrijemeToolStripMenuItem
            // 
            this.radnoVrijemeToolStripMenuItem.Name = "radnoVrijemeToolStripMenuItem";
            this.radnoVrijemeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.radnoVrijemeToolStripMenuItem.Text = "Radno vrijeme";
            this.radnoVrijemeToolStripMenuItem.Click += new System.EventHandler(this.radnoVrijemeToolStripMenuItem_Click);
            // 
            // izgledMapeToolStripMenuItem
            // 
            this.izgledMapeToolStripMenuItem.Name = "izgledMapeToolStripMenuItem";
            this.izgledMapeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.izgledMapeToolStripMenuItem.Text = "Izgled mape";
            this.izgledMapeToolStripMenuItem.Click += new System.EventHandler(this.izgledMapeToolStripMenuItem_Click);
            // 
            // cijeneToolStripMenuItem
            // 
            this.cijeneToolStripMenuItem.Name = "cijeneToolStripMenuItem";
            this.cijeneToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cijeneToolStripMenuItem.Text = "Cijene";
            this.cijeneToolStripMenuItem.Click += new System.EventHandler(this.cijeneToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            this.administratorToolStripMenuItem.Click += new System.EventHandler(this.administratorToolStripMenuItem_Click);
            // 
            // buttonUlaz
            // 
            this.buttonUlaz.Location = new System.Drawing.Point(145, 75);
            this.buttonUlaz.Name = "buttonUlaz";
            this.buttonUlaz.Size = new System.Drawing.Size(205, 41);
            this.buttonUlaz.TabIndex = 2;
            this.buttonUlaz.Text = "Ulaz u garažu";
            this.buttonUlaz.UseVisualStyleBackColor = true;
            this.buttonUlaz.Click += new System.EventHandler(this.buttonUlaz_Click);
            // 
            // labelDate
            // 
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate.Location = new System.Drawing.Point(0, 196);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(487, 30);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonIzlaz
            // 
            this.buttonIzlaz.Location = new System.Drawing.Point(145, 122);
            this.buttonIzlaz.Name = "buttonIzlaz";
            this.buttonIzlaz.Size = new System.Drawing.Size(205, 41);
            this.buttonIzlaz.TabIndex = 5;
            this.buttonIzlaz.Text = "Izlaz iz garaže";
            this.buttonIzlaz.UseVisualStyleBackColor = true;
            this.buttonIzlaz.Click += new System.EventHandler(this.buttonIzlaz_Click);
            // 
            // labelTime
            // 
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(0, 163);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(487, 33);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // timerVrijeme
            // 
            this.timerVrijeme.Enabled = true;
            this.timerVrijeme.Tick += new System.EventHandler(this.timerVrijeme_Tick);
            // 
            // FormParkingGaraza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 226);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonIzlaz);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonUlaz);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormParkingGaraza";
            this.Text = "Parking garaža - Mauro";
            this.Load += new System.EventHandler(this.FormParkingGaraza_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oGaražiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uvjetiPružanjaUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radnoVrijemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izgledMapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.Button buttonUlaz;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonIzlaz;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.Timer timerVrijeme;
        private System.Windows.Forms.ToolStripMenuItem cijeneToolStripMenuItem;
    }
}

