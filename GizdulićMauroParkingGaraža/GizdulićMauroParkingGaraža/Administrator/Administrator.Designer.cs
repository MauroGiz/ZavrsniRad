namespace GizdulićMauroParkingGaraža
{
    partial class Administrator
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
            this.dataGridViewPodaci = new System.Windows.Forms.DataGridView();
            this.bindingSourcePodaci = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.buttonPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPodaci
            // 
            this.dataGridViewPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPodaci.Location = new System.Drawing.Point(33, 12);
            this.dataGridViewPodaci.Name = "dataGridViewPodaci";
            this.dataGridViewPodaci.Size = new System.Drawing.Size(429, 212);
            this.dataGridViewPodaci.TabIndex = 0;
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.Location = new System.Drawing.Point(33, 244);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(75, 23);
            this.buttonPrikazi.TabIndex = 1;
            this.buttonPrikazi.Text = "Prikazi bazu";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.Location = new System.Drawing.Point(188, 244);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(124, 23);
            this.buttonIzbrisi.TabIndex = 2;
            this.buttonIzbrisi.Text = "Izbriši podatke";
            this.buttonIzbrisi.UseVisualStyleBackColor = true;
            this.buttonIzbrisi.Click += new System.EventHandler(this.buttonIzbrisi_Click);
            // 
            // buttonPretrazi
            // 
            this.buttonPretrazi.Location = new System.Drawing.Point(387, 244);
            this.buttonPretrazi.Name = "buttonPretrazi";
            this.buttonPretrazi.Size = new System.Drawing.Size(75, 23);
            this.buttonPretrazi.TabIndex = 3;
            this.buttonPretrazi.Text = "Pretraži";
            this.buttonPretrazi.UseVisualStyleBackColor = true;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 279);
            this.Controls.Add(this.buttonPretrazi);
            this.Controls.Add(this.buttonIzbrisi);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.dataGridViewPodaci);
            this.MaximizeBox = false;
            this.Name = "Administrator";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePodaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPodaci;
        private System.Windows.Forms.BindingSource bindingSourcePodaci;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.Button buttonPretrazi;
    }
}