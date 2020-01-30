namespace Ekstraklasa
{
    partial class MAIN
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
            this.btnBramki = new System.Windows.Forms.Button();
            this.btnDruzyny = new System.Windows.Forms.Button();
            this.btnKartki = new System.Windows.Forms.Button();
            this.btnPilkarze = new System.Windows.Forms.Button();
            this.btnSedziowie = new System.Windows.Forms.Button();
            this.btnSpotkania = new System.Windows.Forms.Button();
            this.btnTrenerzy = new System.Windows.Forms.Button();
            this.lblQA = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBramki
            // 
            this.btnBramki.Location = new System.Drawing.Point(115, 126);
            this.btnBramki.Name = "btnBramki";
            this.btnBramki.Size = new System.Drawing.Size(90, 25);
            this.btnBramki.TabIndex = 0;
            this.btnBramki.Text = "BRAMKI";
            this.btnBramki.UseVisualStyleBackColor = true;
            this.btnBramki.Click += new System.EventHandler(this.btnBramki_Click);
            // 
            // btnDruzyny
            // 
            this.btnDruzyny.Location = new System.Drawing.Point(115, 157);
            this.btnDruzyny.Name = "btnDruzyny";
            this.btnDruzyny.Size = new System.Drawing.Size(90, 25);
            this.btnDruzyny.TabIndex = 1;
            this.btnDruzyny.Text = "DRUZYNY";
            this.btnDruzyny.UseVisualStyleBackColor = true;
            this.btnDruzyny.Click += new System.EventHandler(this.btnDruzyny_Click);
            // 
            // btnKartki
            // 
            this.btnKartki.Location = new System.Drawing.Point(115, 188);
            this.btnKartki.Name = "btnKartki";
            this.btnKartki.Size = new System.Drawing.Size(90, 25);
            this.btnKartki.TabIndex = 2;
            this.btnKartki.Text = "KARTKI";
            this.btnKartki.UseVisualStyleBackColor = true;
            this.btnKartki.Click += new System.EventHandler(this.btnKartki_Click);
            // 
            // btnPilkarze
            // 
            this.btnPilkarze.Location = new System.Drawing.Point(115, 219);
            this.btnPilkarze.Name = "btnPilkarze";
            this.btnPilkarze.Size = new System.Drawing.Size(90, 25);
            this.btnPilkarze.TabIndex = 3;
            this.btnPilkarze.Text = "PILKARZE";
            this.btnPilkarze.UseVisualStyleBackColor = true;
            this.btnPilkarze.Click += new System.EventHandler(this.btnPilkarze_Click);
            // 
            // btnSedziowie
            // 
            this.btnSedziowie.Location = new System.Drawing.Point(115, 250);
            this.btnSedziowie.Name = "btnSedziowie";
            this.btnSedziowie.Size = new System.Drawing.Size(90, 25);
            this.btnSedziowie.TabIndex = 4;
            this.btnSedziowie.Text = "SEDZIOWIE";
            this.btnSedziowie.UseVisualStyleBackColor = true;
            this.btnSedziowie.Click += new System.EventHandler(this.btnSedziowie_Click);
            // 
            // btnSpotkania
            // 
            this.btnSpotkania.Location = new System.Drawing.Point(115, 281);
            this.btnSpotkania.Name = "btnSpotkania";
            this.btnSpotkania.Size = new System.Drawing.Size(90, 25);
            this.btnSpotkania.TabIndex = 5;
            this.btnSpotkania.Text = "SPOTKANIA";
            this.btnSpotkania.UseVisualStyleBackColor = true;
            this.btnSpotkania.Click += new System.EventHandler(this.btnSpotkania_Click);
            // 
            // btnTrenerzy
            // 
            this.btnTrenerzy.Location = new System.Drawing.Point(115, 312);
            this.btnTrenerzy.Name = "btnTrenerzy";
            this.btnTrenerzy.Size = new System.Drawing.Size(90, 25);
            this.btnTrenerzy.TabIndex = 6;
            this.btnTrenerzy.Text = "TRENERZY";
            this.btnTrenerzy.UseVisualStyleBackColor = true;
            this.btnTrenerzy.Click += new System.EventHandler(this.btnTrenerzy_Click);
            // 
            // lblQA
            // 
            this.lblQA.AutoSize = true;
            this.lblQA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQA.Location = new System.Drawing.Point(112, 85);
            this.lblQA.Name = "lblQA";
            this.lblQA.Size = new System.Drawing.Size(111, 13);
            this.lblQA.TabIndex = 7;
            this.lblQA.Text = "Co chcesz zrobić?";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(115, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 25);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "WYJDŹ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 451);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblQA);
            this.Controls.Add(this.btnTrenerzy);
            this.Controls.Add(this.btnSpotkania);
            this.Controls.Add(this.btnSedziowie);
            this.Controls.Add(this.btnPilkarze);
            this.Controls.Add(this.btnKartki);
            this.Controls.Add(this.btnDruzyny);
            this.Controls.Add(this.btnBramki);
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekstraklasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBramki;
        private System.Windows.Forms.Button btnDruzyny;
        private System.Windows.Forms.Button btnKartki;
        private System.Windows.Forms.Button btnPilkarze;
        private System.Windows.Forms.Button btnSedziowie;
        private System.Windows.Forms.Button btnSpotkania;
        private System.Windows.Forms.Button btnTrenerzy;
        private System.Windows.Forms.Label lblQA;
        private System.Windows.Forms.Button btnExit;
    }
}