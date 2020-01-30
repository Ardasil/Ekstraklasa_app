namespace Ekstraklasa
{
    partial class PLAYERS
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
            this.btnBack = new System.Windows.Forms.Button();
            this.datGrid = new System.Windows.Forms.DataGridView();
            this.Id_pilkarze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_druz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie_pilk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko_pilk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa_druz_pilk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wiek_pilk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc_meczy_pilk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc_strzelonych_goli_pilk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc_wpuszczonych_goli_pilk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specjalizacja = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtCol6 = new System.Windows.Forms.TextBox();
            this.txtCol7 = new System.Windows.Forms.TextBox();
            this.txtCol8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCol9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(125, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 19;
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
            this.Id_pilkarze,
            this.Id_druz,
            this.Imie_pilk,
            this.Nazwisko_pilk,
            this.Nazwa_druz_pilk,
            this.Wiek_pilk,
            this.Ilosc_meczy_pilk,
            this.Ilosc_strzelonych_goli_pilk,
            this.Ilosc_wpuszczonych_goli_pilk,
            this.Specjalizacja});
            this.datGrid.Location = new System.Drawing.Point(338, 12);
            this.datGrid.Name = "datGrid";
            this.datGrid.ReadOnly = true;
            this.datGrid.RowTemplate.Height = 30;
            this.datGrid.Size = new System.Drawing.Size(744, 422);
            this.datGrid.TabIndex = 18;
            this.datGrid.DoubleClick += new System.EventHandler(this.datGrid_DoubleClick);
            // 
            // Id_pilkarze
            // 
            this.Id_pilkarze.DataPropertyName = "Id_pilkarze";
            this.Id_pilkarze.HeaderText = "ID_pilkarz";
            this.Id_pilkarze.Name = "Id_pilkarze";
            this.Id_pilkarze.ReadOnly = true;
            this.Id_pilkarze.Visible = false;
            // 
            // Id_druz
            // 
            this.Id_druz.DataPropertyName = "Id_druz";
            this.Id_druz.HeaderText = "ID_druz";
            this.Id_druz.Name = "Id_druz";
            this.Id_druz.ReadOnly = true;
            this.Id_druz.Visible = false;
            // 
            // Imie_pilk
            // 
            this.Imie_pilk.DataPropertyName = "Imie_pilk";
            this.Imie_pilk.HeaderText = "Imię";
            this.Imie_pilk.Name = "Imie_pilk";
            this.Imie_pilk.ReadOnly = true;
            // 
            // Nazwisko_pilk
            // 
            this.Nazwisko_pilk.DataPropertyName = "Nazwisko_pilk";
            this.Nazwisko_pilk.HeaderText = "Nazwisko";
            this.Nazwisko_pilk.Name = "Nazwisko_pilk";
            this.Nazwisko_pilk.ReadOnly = true;
            // 
            // Nazwa_druz_pilk
            // 
            this.Nazwa_druz_pilk.DataPropertyName = "Nazwa_druz_pilk";
            this.Nazwa_druz_pilk.HeaderText = "Drużyna";
            this.Nazwa_druz_pilk.Name = "Nazwa_druz_pilk";
            this.Nazwa_druz_pilk.ReadOnly = true;
            // 
            // Wiek_pilk
            // 
            this.Wiek_pilk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Wiek_pilk.DataPropertyName = "Wiek_pilk";
            this.Wiek_pilk.HeaderText = "Wiek";
            this.Wiek_pilk.Name = "Wiek_pilk";
            this.Wiek_pilk.ReadOnly = true;
            this.Wiek_pilk.Width = 57;
            // 
            // Ilosc_meczy_pilk
            // 
            this.Ilosc_meczy_pilk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ilosc_meczy_pilk.DataPropertyName = "Ilosc_meczy_pilk";
            this.Ilosc_meczy_pilk.HeaderText = "Mecze";
            this.Ilosc_meczy_pilk.Name = "Ilosc_meczy_pilk";
            this.Ilosc_meczy_pilk.ReadOnly = true;
            this.Ilosc_meczy_pilk.Width = 64;
            // 
            // Ilosc_strzelonych_goli_pilk
            // 
            this.Ilosc_strzelonych_goli_pilk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ilosc_strzelonych_goli_pilk.DataPropertyName = "Ilosc_strzelonych_goli_pilk";
            this.Ilosc_strzelonych_goli_pilk.HeaderText = "Gole strzelone";
            this.Ilosc_strzelonych_goli_pilk.Name = "Ilosc_strzelonych_goli_pilk";
            this.Ilosc_strzelonych_goli_pilk.ReadOnly = true;
            this.Ilosc_strzelonych_goli_pilk.Width = 99;
            // 
            // Ilosc_wpuszczonych_goli_pilk
            // 
            this.Ilosc_wpuszczonych_goli_pilk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ilosc_wpuszczonych_goli_pilk.DataPropertyName = "Ilosc_wpuszczonych_goli_pilk";
            this.Ilosc_wpuszczonych_goli_pilk.HeaderText = "Gole stracone";
            this.Ilosc_wpuszczonych_goli_pilk.Name = "Ilosc_wpuszczonych_goli_pilk";
            this.Ilosc_wpuszczonych_goli_pilk.ReadOnly = true;
            this.Ilosc_wpuszczonych_goli_pilk.Width = 98;
            // 
            // Specjalizacja
            // 
            this.Specjalizacja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Specjalizacja.DataPropertyName = "Specjalizacja";
            this.Specjalizacja.HeaderText = "Pozycja";
            this.Specjalizacja.Name = "Specjalizacja";
            this.Specjalizacja.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(125, 379);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Usuń";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(44, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Dodaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCol5
            // 
            this.txtCol5.Location = new System.Drawing.Point(106, 183);
            this.txtCol5.Name = "txtCol5";
            this.txtCol5.Size = new System.Drawing.Size(140, 20);
            this.txtCol5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Wiek";
            // 
            // txtCol4
            // 
            this.txtCol4.Location = new System.Drawing.Point(106, 143);
            this.txtCol4.Name = "txtCol4";
            this.txtCol4.Size = new System.Drawing.Size(140, 20);
            this.txtCol4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Drużyna";
            // 
            // txtCol3
            // 
            this.txtCol3.Location = new System.Drawing.Point(106, 103);
            this.txtCol3.Name = "txtCol3";
            this.txtCol3.Size = new System.Drawing.Size(140, 20);
            this.txtCol3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nazwisko";
            // 
            // txtCol2
            // 
            this.txtCol2.Location = new System.Drawing.Point(106, 63);
            this.txtCol2.Name = "txtCol2";
            this.txtCol2.Size = new System.Drawing.Size(140, 20);
            this.txtCol2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Imię";
            // 
            // txtCol1
            // 
            this.txtCol1.Location = new System.Drawing.Point(106, 23);
            this.txtCol1.Name = "txtCol1";
            this.txtCol1.Size = new System.Drawing.Size(140, 20);
            this.txtCol1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Drużyny";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Rozegrane mecze";
            // 
            // txtCol6
            // 
            this.txtCol6.Location = new System.Drawing.Point(106, 223);
            this.txtCol6.Name = "txtCol6";
            this.txtCol6.Size = new System.Drawing.Size(140, 20);
            this.txtCol6.TabIndex = 21;
            // 
            // txtCol7
            // 
            this.txtCol7.Location = new System.Drawing.Point(106, 263);
            this.txtCol7.Name = "txtCol7";
            this.txtCol7.Size = new System.Drawing.Size(140, 20);
            this.txtCol7.TabIndex = 22;
            // 
            // txtCol8
            // 
            this.txtCol8.Location = new System.Drawing.Point(106, 303);
            this.txtCol8.Name = "txtCol8";
            this.txtCol8.Size = new System.Drawing.Size(140, 20);
            this.txtCol8.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Gole strzelone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Gole stracone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Pozycja";
            // 
            // txtCol9
            // 
            this.txtCol9.Location = new System.Drawing.Point(106, 344);
            this.txtCol9.Name = "txtCol9";
            this.txtCol9.Size = new System.Drawing.Size(140, 20);
            this.txtCol9.TabIndex = 27;
            // 
            // PLAYERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 450);
            this.Controls.Add(this.txtCol9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCol8);
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
            this.Name = "PLAYERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piłkarze";
            this.Load += new System.EventHandler(this.btnCancel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.datGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCol6;
        private System.Windows.Forms.TextBox txtCol7;
        private System.Windows.Forms.TextBox txtCol8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCol9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_pilkarze;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_druz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie_pilk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko_pilk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa_druz_pilk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wiek_pilk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc_meczy_pilk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc_strzelonych_goli_pilk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc_wpuszczonych_goli_pilk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specjalizacja;
    }
}