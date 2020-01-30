using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Ekstraklasa
{
    public partial class REFEREES : Form
    {
        SEDZIOWIE model = new SEDZIOWIE();
        public REFEREES()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtCol1.Text = txtCol2.Text = txtCol3.Text = txtCol4.Text = txtCol5.Text = txtCol6.Text = "";
            btnSave.Text = "Save";
            btnDel.Enabled = false;
            model.Id_sed = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Id_gospo = System.Convert.ToInt32(txtCol1.Text.Trim());
            model.Id_gosc = System.Convert.ToInt32(txtCol2.Text.Trim());
            model.Imie_sed = txtCol3.Text.Trim();
            model.Nazwisko_sed = txtCol4.Text.Trim();
            model.Wiek_sed = System.Convert.ToInt32(txtCol5.Text.Trim());
            model.Ilosc_wydanych_kartek = System.Convert.ToInt32(txtCol6.Text.Trim());

            using (EkstraklasaEntities db = new EkstraklasaEntities())
            {
                if (model.Id_sed == 0) //Insert
                    db.SEDZIOWIE.Add(model);
                else //Update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            clear();
            PopulateDataGridView();
            MessageBox.Show("Sukces");
        }
        void PopulateDataGridView()
        {
            datGrid.AutoGenerateColumns = false;
            using (EkstraklasaEntities db = new EkstraklasaEntities())
            {
                datGrid.DataSource = db.SEDZIOWIE.ToList<SEDZIOWIE>();
            }
        }

        private void datGrid_DoubleClick(object sender, EventArgs e)
        {
            if (datGrid.CurrentRow.Index != -1)
            {
                model.Id_sed = Convert.ToInt32(datGrid.CurrentRow.Cells["Id_sed"].Value);
                using (EkstraklasaEntities db = new EkstraklasaEntities())
                {
                    model = db.SEDZIOWIE.Where(x => x.Id_sed == model.Id_sed).FirstOrDefault();
                    txtCol1.Text = System.Convert.ToString(model.Id_gospo);
                    txtCol2.Text = System.Convert.ToString(model.Id_gosc);
                    txtCol3.Text = model.Imie_sed;
                    txtCol4.Text = model.Nazwisko_sed;
                    txtCol5.Text = System.Convert.ToString(model.Wiek_sed);
                    txtCol6.Text = System.Convert.ToString(model.Ilosc_wydanych_kartek);
                }
                btnSave.Text = "Update";
                btnDel.Enabled = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno chcesz usunąć ten rekord?", "Usunięcie rekordu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (EkstraklasaEntities db = new EkstraklasaEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)

                        db.SEDZIOWIE.Attach(model);
                    db.SEDZIOWIE.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    clear();
                    MessageBox.Show("Usunięto pomyślnie");

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MAIN ss = new MAIN();
            ss.Show();
        }
    }
}
