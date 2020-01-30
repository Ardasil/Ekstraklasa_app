namespace Ekstraklasa
{
    partial class MATCHES
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
            this.Id_gospo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_gosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gospodarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRU_Id_druz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miejsce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wynik_gospo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wynik_gosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label7.Location = new System.Drawing.Point(12, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Wynik gości";
            // 
            // txtCol7
            // 
            this.txtCol7.Location = new System.Drawing.Point(110, 267);
            this.txtCol7.Name = "txtCol7";
            this.txtCol7.Size = new System.Drawing.Size(140, 20);
            this.txtCol7.TabIndex = 65;
            // 
            // txtCol6
            // 
            this.txtCol6.Location = new System.Drawing.Point(110, 227);
            this.txtCol6.Name = "txtCol6";
            this.txtCol6.Size = new System.Drawing.Size(140, 20);
            this.txtCol6.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Wynik gospodarza";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(129, 391);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 62;
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
            this.Id_gospo,
            this.Id_gosc,
            this.Gospodarz,
            this.DRU_Id_druz,
            this.Data,
            this.Godzina,
            this.Miejsce,
            this.Wynik_gospo,
            this.Wynik_gosc});
            this.datGrid.Location = new System.Drawing.Point(338, 12);
            this.datGrid.Name = "datGrid";
            this.datGrid.ReadOnly = true;
            this.datGrid.RowTemplate.Height = 30;
            this.datGrid.Size = new System.Drawing.Size(744, 422);
            this.datGrid.TabIndex = 61;
            this.datGrid.DoubleClick += new System.EventHandler(this.datGrid_DoubleClick);
            // 
            // Id_gospo
            // 
            this.Id_gospo.DataPropertyName = "Id_gospo";
            this.Id_gospo.HeaderText = "Gospodarz";
            this.Id_gospo.Name = "Id_gospo";
            this.Id_gospo.ReadOnly = true;
            this.Id_gospo.Visible = false;
            // 
            // Id_gosc
            // 
            this.Id_gosc.DataPropertyName = "Id_gosc";
            this.Id_gosc.HeaderText = "Gość";
            this.Id_gosc.Name = "Id_gosc";
            this.Id_gosc.ReadOnly = true;
            this.Id_gosc.Visible = false;
            // 
            // Gospodarz
            // 
            this.Gospodarz.DataPropertyName = "Id_druz";
            this.Gospodarz.HeaderText = "Gospodarz";
            this.Gospodarz.Name = "Gospodarz";
            this.Gospodarz.ReadOnly = true;
            // 
            // DRU_Id_druz
            // 
            this.DRU_Id_druz.DataPropertyName = "DRU_Id_druz";
            this.DRU_Id_druz.HeaderText = "Gość";
            this.DRU_Id_druz.Name = "DRU_Id_druz";
            this.DRU_Id_druz.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Godzina
            // 
            this.Godzina.DataPropertyName = "Godzina";
            this.Godzina.HeaderText = "Godzina";
            this.Godzina.Name = "Godzina";
            this.Godzina.ReadOnly = true;
            // 
            // Miejsce
            // 
            this.Miejsce.DataPropertyName = "Miejsce";
            this.Miejsce.HeaderText = "Miejsce";
            this.Miejsce.Name = "Miejsce";
            this.Miejsce.ReadOnly = true;
            // 
            // Wynik_gospo
            // 
            this.Wynik_gospo.DataPropertyName = "Wynik_gospo";
            this.Wynik_gospo.HeaderText = "Wynik gospodarzy";
            this.Wynik_gospo.Name = "Wynik_gospo";
            this.Wynik_gospo.ReadOnly = true;
            // 
            // Wynik_gosc
            // 
            this.Wynik_gosc.DataPropertyName = "Wynik_gosc";
            this.Wynik_gosc.HeaderText = "Wynik gości";
            this.Wynik_gosc.Name = "Wynik_gosc";
            this.Wynik_gosc.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(129, 320);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 59;
            this.btnDel.Text = "Usuń";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(48, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 60;
            this.btnSave.Text = "Dodaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCol5
            // 
            this.txtCol5.Location = new System.Drawing.Point(110, 187);
            this.txtCol5.Name = "txtCol5";
            this.txtCol5.Size = new System.Drawing.Size(140, 20);
            this.txtCol5.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Miejsce meczu";
            // 
            // txtCol4
            // 
            this.txtCol4.Location = new System.Drawing.Point(110, 147);
            this.txtCol4.Name = "txtCol4";
            this.txtCol4.Size = new System.Drawing.Size(140, 20);
            this.txtCol4.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Godzina";
            // 
            // txtCol3
            // 
            this.txtCol3.Location = new System.Drawing.Point(110, 107);
            this.txtCol3.Name = "txtCol3";
            this.txtCol3.Size = new System.Drawing.Size(140, 20);
            this.txtCol3.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Data";
            // 
            // txtCol2
            // 
            this.txtCol2.Location = new System.Drawing.Point(110, 67);
            this.txtCol2.Name = "txtCol2";
            this.txtCol2.Size = new System.Drawing.Size(140, 20);
            this.txtCol2.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "ID Gości";
            // 
            // txtCol1
            // 
            this.txtCol1.Location = new System.Drawing.Point(110, 27);
            this.txtCol1.Name = "txtCol1";
            this.txtCol1.Size = new System.Drawing.Size(140, 20);
            this.txtCol1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "ID Gospodarza";
            // 
            // MATCHES
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
            this.Name = "MATCHES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spotkania";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_gospo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_gosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gospodarz;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRU_Id_druz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miejsce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wynik_gospo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wynik_gosc;
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
    }
}