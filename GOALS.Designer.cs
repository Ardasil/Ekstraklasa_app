namespace Ekstraklasa
{
    partial class GOALS
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
            this.Id_strzelec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_gospo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_gosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_pilkarze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIL_Id_pilkarze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Czas_bramki = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(123, 397);
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
            this.Id_strzelec,
            this.Id_gospo,
            this.Id_gosc,
            this.Id_pilkarze,
            this.PIL_Id_pilkarze,
            this.Czas_bramki});
            this.datGrid.Location = new System.Drawing.Point(333, 12);
            this.datGrid.Name = "datGrid";
            this.datGrid.ReadOnly = true;
            this.datGrid.RowTemplate.Height = 30;
            this.datGrid.Size = new System.Drawing.Size(595, 422);
            this.datGrid.TabIndex = 18;
            this.datGrid.DoubleClick += new System.EventHandler(this.datGrid_DoubleClick);
            // 
            // Id_strzelec
            // 
            this.Id_strzelec.DataPropertyName = "Id_strzelec";
            this.Id_strzelec.HeaderText = "Id_strzelec";
            this.Id_strzelec.Name = "Id_strzelec";
            this.Id_strzelec.ReadOnly = true;
            this.Id_strzelec.Visible = false;
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
            // Id_pilkarze
            // 
            this.Id_pilkarze.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_pilkarze.DataPropertyName = "Id_pilkarze";
            this.Id_pilkarze.HeaderText = "Strzelec";
            this.Id_pilkarze.Name = "Id_pilkarze";
            this.Id_pilkarze.ReadOnly = true;
            // 
            // PIL_Id_pilkarze
            // 
            this.PIL_Id_pilkarze.DataPropertyName = "PIL_Id_pilkarze";
            this.PIL_Id_pilkarze.HeaderText = "Bramkarz";
            this.PIL_Id_pilkarze.Name = "PIL_Id_pilkarze";
            this.PIL_Id_pilkarze.ReadOnly = true;
            this.PIL_Id_pilkarze.Width = 120;
            // 
            // Czas_bramki
            // 
            this.Czas_bramki.DataPropertyName = "Czas_bramki";
            this.Czas_bramki.HeaderText = "Czas bramki";
            this.Czas_bramki.Name = "Czas_bramki";
            this.Czas_bramki.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(123, 308);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Usuń";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Dodaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCol5
            // 
            this.txtCol5.Location = new System.Drawing.Point(104, 226);
            this.txtCol5.Name = "txtCol5";
            this.txtCol5.Size = new System.Drawing.Size(140, 20);
            this.txtCol5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Czas bramki";
            // 
            // txtCol4
            // 
            this.txtCol4.Location = new System.Drawing.Point(104, 186);
            this.txtCol4.Name = "txtCol4";
            this.txtCol4.Size = new System.Drawing.Size(140, 20);
            this.txtCol4.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Bramkarza";
            // 
            // txtCol3
            // 
            this.txtCol3.Location = new System.Drawing.Point(104, 146);
            this.txtCol3.Name = "txtCol3";
            this.txtCol3.Size = new System.Drawing.Size(140, 20);
            this.txtCol3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Strzelca";
            // 
            // txtCol2
            // 
            this.txtCol2.Location = new System.Drawing.Point(104, 106);
            this.txtCol2.Name = "txtCol2";
            this.txtCol2.Size = new System.Drawing.Size(140, 20);
            this.txtCol2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Gościa";
            // 
            // txtCol1
            // 
            this.txtCol1.Location = new System.Drawing.Point(104, 66);
            this.txtCol1.Name = "txtCol1";
            this.txtCol1.Size = new System.Drawing.Size(140, 20);
            this.txtCol1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Gospodarza";
            // 
            // GOALS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 449);
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
            this.Name = "GOALS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bramki";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_strzelec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_gospo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_gosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_pilkarze;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIL_Id_pilkarze;
        private System.Windows.Forms.DataGridViewTextBoxColumn Czas_bramki;
    }
}