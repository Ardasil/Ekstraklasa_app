namespace Ekstraklasa
{
    partial class CARDS
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtCol7 = new System.Windows.Forms.TextBox();
            this.txtCol6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.datGrid = new System.Windows.Forms.DataGridView();
            this.Id_kartki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_pilkarze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_sed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_gospo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_gosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rodzaj_kartki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa_sed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa_pilk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCol5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCol4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCol3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCol2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCol1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Piłkarz";
            // 
            // txtCol7
            // 
            this.txtCol7.Location = new System.Drawing.Point(106, 263);
            this.txtCol7.Name = "txtCol7";
            this.txtCol7.Size = new System.Drawing.Size(140, 20);
            this.txtCol7.TabIndex = 45;
            // 
            // txtCol6
            // 
            this.txtCol6.Location = new System.Drawing.Point(106, 223);
            this.txtCol6.Name = "txtCol6";
            this.txtCol6.Size = new System.Drawing.Size(140, 20);
            this.txtCol6.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Sędzia";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(125, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Wróć";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // datGrid
            // 
            this.datGrid.AllowUserToDeleteRows = false;
            this.datGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.datGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_kartki,
            this.Id_pilkarze,
            this.Id_sed,
            this.Id_gospo,
            this.Id_gosc,
            this.Rodzaj_kartki,
            this.Nazwa_sed,
            this.Nazwa_pilk});
            this.datGrid.Location = new System.Drawing.Point(338, 12);
            this.datGrid.Name = "datGrid";
            this.datGrid.ReadOnly = true;
            this.datGrid.RowTemplate.Height = 30;
            this.datGrid.Size = new System.Drawing.Size(744, 422);
            this.datGrid.TabIndex = 41;
            this.datGrid.DoubleClick += new System.EventHandler(this.datGrid_DoubleClick);
            // 
            // Id_kartki
            // 
            this.Id_kartki.DataPropertyName = "Id_kartki";
            this.Id_kartki.HeaderText = "Id_kartki";
            this.Id_kartki.Name = "Id_kartki";
            this.Id_kartki.ReadOnly = true;
            this.Id_kartki.Visible = false;
            // 
            // Id_pilkarze
            // 
            this.Id_pilkarze.DataPropertyName = "Id_pilkarze";
            this.Id_pilkarze.HeaderText = "ID Piłkarza";
            this.Id_pilkarze.Name = "Id_pilkarze";
            this.Id_pilkarze.ReadOnly = true;
            // 
            // Id_sed
            // 
            this.Id_sed.DataPropertyName = "Id_sed";
            this.Id_sed.HeaderText = "ID Sędziego";
            this.Id_sed.Name = "Id_sed";
            this.Id_sed.ReadOnly = true;
            // 
            // Id_gospo
            // 
            this.Id_gospo.DataPropertyName = "Id_gospo";
            this.Id_gospo.HeaderText = "Gospodarz";
            this.Id_gospo.Name = "Id_gospo";
            this.Id_gospo.ReadOnly = true;
            // 
            // Id_gosc
            // 
            this.Id_gosc.DataPropertyName = "Id_gosc";
            this.Id_gosc.HeaderText = "Gość";
            this.Id_gosc.Name = "Id_gosc";
            this.Id_gosc.ReadOnly = true;
            // 
            // Rodzaj_kartki
            // 
            this.Rodzaj_kartki.DataPropertyName = "Rodzaj_kartki";
            this.Rodzaj_kartki.HeaderText = "Kartka";
            this.Rodzaj_kartki.Name = "Rodzaj_kartki";
            this.Rodzaj_kartki.ReadOnly = true;
            // 
            // Nazwa_sed
            // 
            this.Nazwa_sed.DataPropertyName = "Nazwa_sed";
            this.Nazwa_sed.HeaderText = "Sędzia";
            this.Nazwa_sed.Name = "Nazwa_sed";
            this.Nazwa_sed.ReadOnly = true;
            // 
            // Nazwa_pilk
            // 
            this.Nazwa_pilk.DataPropertyName = "Nazwa_pilk";
            this.Nazwa_pilk.HeaderText = "Piłkarz";
            this.Nazwa_pilk.Name = "Nazwa_pilk";
            this.Nazwa_pilk.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(125, 316);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 39;
            this.btnDel.Text = "Usuń";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(44, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Dodaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCol5
            // 
            this.txtCol5.Location = new System.Drawing.Point(106, 183);
            this.txtCol5.Name = "txtCol5";
            this.txtCol5.Size = new System.Drawing.Size(140, 20);
            this.txtCol5.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Rodzaj kartki";
            // 
            // txtCol4
            // 
            this.txtCol4.Location = new System.Drawing.Point(106, 143);
            this.txtCol4.Name = "txtCol4";
            this.txtCol4.Size = new System.Drawing.Size(140, 20);
            this.txtCol4.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "ID Gościa";
            // 
            // txtCol3
            // 
            this.txtCol3.Location = new System.Drawing.Point(106, 103);
            this.txtCol3.Name = "txtCol3";
            this.txtCol3.Size = new System.Drawing.Size(140, 20);
            this.txtCol3.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID Gospodarza";
            // 
            // txtCol2
            // 
            this.txtCol2.Location = new System.Drawing.Point(106, 63);
            this.txtCol2.Name = "txtCol2";
            this.txtCol2.Size = new System.Drawing.Size(140, 20);
            this.txtCol2.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID Sędziego";
            // 
            // txtCol1
            // 
            this.txtCol1.Location = new System.Drawing.Point(106, 23);
            this.txtCol1.Name = "txtCol1";
            this.txtCol1.Size = new System.Drawing.Size(140, 20);
            this.txtCol1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID Piłkarza";
            // 
            // CARDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCol7);
            this.Controls.Add(this.txtCol6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.datGrid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCol5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCol4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCol3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCol2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCol1);
            this.Controls.Add(this.label1);
            this.Name = "CARDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kartki";
            this.Load += new System.EventHandler(this.btnCancel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.datGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCol7;
        private System.Windows.Forms.TextBox txtCol6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView datGrid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCol5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCol4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCol3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCol2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCol1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_kartki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_pilkarze;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_sed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_gospo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_gosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rodzaj_kartki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa_sed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa_pilk;
    }
}