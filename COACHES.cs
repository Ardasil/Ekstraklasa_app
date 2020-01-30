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
    public partial class COACHES : Form
    {
        TRENERZY model = new TRENERZY();
        public COACHES()
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
            txtCol1.Text = txtCol2.Text = txtCol3.Text = txtCol4.Text = txtCol5.Text = "";
            btnSave.Text = "Save";
            btnDel.Enabled = false;
            model.Id_tren = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Id_druz = System.Convert.ToInt32(txtCol1.Text.Trim());
            model.Imie_tren = txtCol2.Text.Trim();
            model.Nazwisko_tren = txtCol3.Text.Trim();
            model.Nazwa_druz_tren = txtCol4.Text.Trim();
            model.Wiek_tren = System.Convert.ToInt32(txtCol5.Text.Trim());

            using (EkstraklasaEntities db = new EkstraklasaEntities())
            {
                if (model.Id_tren == 0) //Insert
                    db.TRENERZY.Add(model);
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
                datGrid.DataSource = db.TRENERZY.ToList<TRENERZY>();
            }
        }

        private void datGrid_DoubleClick(object sender, EventArgs e)
        {
            if (datGrid.CurrentRow.Index != -1)
            {
                model.Id_tren = Convert.ToInt32(datGrid.CurrentRow.Cells["Id_tren"].Value);
                using (EkstraklasaEntities db = new EkstraklasaEntities())
                {
                    model = db.TRENERZY.Where(x => x.Id_tren == model.Id_tren).FirstOrDefault();
                    txtCol1.Text = System.Convert.ToString(model.Id_druz);
                    txtCol2.Text = model.Imie_tren;
                    txtCol3.Text = model.Nazwisko_tren;
                    txtCol4.Text = model.Nazwa_druz_tren;
                    txtCol5.Text = System.Convert.ToString(model.Wiek_tren);
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

                        db.TRENERZY.Attach(model);
                    db.TRENERZY.Remove(model);
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
