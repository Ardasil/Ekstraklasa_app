namespace Ekstraklasa
{
    partial class TEAMS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCol1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.datGrid = new System.Windows.Forms.DataGridView();
            this.Id_druz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa_druz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wlasciciel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siedziba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc_rozegranych_meczy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punkty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCol2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCol3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCol4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCol5 = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa drużyny";
            // 
            // txtCol1
            // 
            this.txtCol1.Location = new System.Drawing.Point(104, 66);
            this.txtCol1.Name = "txtCol1";
            this.txtCol1.Size = new System.Drawing.Size(140, 20);
            this.txtCol1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Dodaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // datGrid
            // 
            this.datGrid.AllowUserToDeleteRows = false;
            this.datGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.datGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_druz,
            this.Nazwa_druz,
            this.Wlasciciel,
            this.Siedziba,
            this.Ilosc_rozegranych_meczy,
            this.Punkty});
            this.datGrid.Location = new System.Drawing.Point(333, 12);
            this.datGrid.Name = "datGrid";
            this.datGrid.ReadOnly = true;
            this.datGrid.RowTemplate.Height = 30;
            this.datGrid.Size = new System.Drawing.Size(595, 422);
            this.datGrid.TabIndex = 3;
            this.datGrid.DoubleClick += new System.EventHandler(this.datGrid_DoubleClick);
            // 
            // Id_druz
            // 
            this.Id_druz.DataPropertyName = "Id_druz";
            this.Id_druz.HeaderText = "Id_druz";
            this.Id_druz.Name = "Id_druz";
            this.Id_druz.ReadOnly = true;
            this.Id_druz.Visible = false;
            // 
            // Nazwa_druz
            // 
            this.Nazwa_druz.DataPropertyName = "Nazwa_druz";
            this.Nazwa_druz.HeaderText = "Nazwa drużyny";
            this.Nazwa_druz.Name = "Nazwa_druz";
            this.Nazwa_druz.ReadOnly = true;
            // 
            // Wlasciciel
            // 
            this.Wlasciciel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Wlasciciel.DataPropertyName = "Wlasciciel";
            this.Wlasciciel.HeaderText = "Właściciel";
            this.Wlasciciel.Name = "Wlasciciel";
            this.Wlasciciel.ReadOnly = true;
            // 
            // Siedziba
            // 
            this.Siedziba.DataPropertyName = "Siedziba";
            this.Siedziba.HeaderText = "Siedziba";
            this.Siedziba.Name = "Siedziba";
            this.Siedziba.ReadOnly = true;
            // 
            // Ilosc_rozegranych_meczy
            // 
            this.Ilosc_rozegranych_meczy.DataPropertyName = "Ilosc_rozegranych_meczy";
            this.Ilosc_rozegranych_meczy.HeaderText = "Mecze";
            this.Ilosc_rozegranych_meczy.Name = "Ilosc_rozegranych_meczy";
            this.Ilosc_rozegranych_meczy.ReadOnly = true;
            // 
            // Punkty
            // 
            this.Punkty.DataPropertyName = "Punkty";
            this.Punkty.HeaderText = "Punkty";
            this.Punkty.Name = "Punkty";
            this.Punkty.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Właściciel";
            // 
            // txtCol2
            // 
            this.txtCol2.Location = new System.Drawing.Point(104, 106);
            this.txtCol2.Name = "txtCol2";
            this.txtCol2.Size = new System.Drawing.Size(140, 20);
            this.txtCol2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Siedziba";
            // 
            // txtCol3
            // 
            this.txtCol3.Location = new System.Drawing.Point(104, 146);
            this.txtCol3.Name = "txtCol3";
            this.txtCol3.Size = new System.Drawing.Size(140, 20);
            this.txtCol3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mecze";
            // 
            // txtCol4
            // 
            this.txtCol4.Location = new System.Drawing.Point(104, 186);
            this.txtCol4.Name = "txtCol4";
            this.txtCol4.Size = new System.Drawing.Size(140, 20);
            this.txtCol4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Punkty";
            // 
            // txtCol5
            // 
            this.txtCol5.Location = new System.Drawing.Point(104, 226);
            this.txtCol5.Name = "txtCol5";
            this.txtCol5.Size = new System.Drawing.Size(140, 20);
            this.txtCol5.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(123, 308);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 30);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Usuń";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(123, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Wróć";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TEAMS
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
            this.Name = "TEAMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drużyny";
            this.Load += new System.EventHandler(this.btnCancel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.datGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCol1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView datGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCol2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCol3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCol4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCol5;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_druz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa_druz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wlasciciel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siedziba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc_rozegranych_meczy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punkty;
        private System.Windows.Forms.Button btnBack;
    }
}

