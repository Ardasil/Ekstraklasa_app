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
using System.Data.Sql;

namespace Ekstraklasa
{
    public partial class CARDS : Form
    {

        KARTKI model = new KARTKI();
        public CARDS()
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
            txtCol1.Text = txtCol2.Text = txtCol3.Text = txtCol4.Text = txtCol5.Text = txtCol6.Text = txtCol7.Text = "";
            btnSave.Text = "Save";
            btnDel.Enabled = false;
            model.Id_kartki = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Id_pilkarze = System.Convert.ToInt32(txtCol1.Text.Trim());
            model.Id_sed = System.Convert.ToInt32(txtCol2.Text.Trim());
            model.Id_gospo = System.Convert.ToInt32(txtCol3.Text.Trim());
            model.Id_gosc = System.Convert.ToInt32(txtCol4.Text.Trim());
            model.Rodzaj_kartki = System.Convert.ToInt32(txtCol5.Text.Trim());
            model.Nazwa_sed = txtCol6.Text.Trim();
            model.Nazwa_pilk = txtCol7.Text.Trim();

            using (EkstraklasaEntities db = new EkstraklasaEntities())
            {
                if (model.Id_pilkarze == 0) //Insert
                    db.KARTKI.Add(model);
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
                datGrid.DataSource = db.KARTKI.ToList<KARTKI>();
            }
        }

        private void datGrid_DoubleClick(object sender, EventArgs e)
        {
            if (datGrid.CurrentRow.Index != -1)
            {
                model.Id_kartki = Convert.ToInt32(datGrid.CurrentRow.Cells["Id_kartki"].Value);
                using (EkstraklasaEntities db = new EkstraklasaEntities())
                {
                    model = db.KARTKI.Where(x => x.Id_kartki == model.Id_kartki).FirstOrDefault();
                    txtCol1.Text = System.Convert.ToString(model.Id_pilkarze);
                    txtCol2.Text = System.Convert.ToString(model.Id_sed);
                    txtCol3.Text = System.Convert.ToString(model.Id_gospo);
                    txtCol4.Text = System.Convert.ToString(model.Id_gosc);
                    txtCol5.Text = System.Convert.ToString(model.Rodzaj_kartki);
                    txtCol6.Text = model.Nazwa_sed;
                    txtCol7.Text = model.Nazwa_pilk;
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

                        db.KARTKI.Attach(model);
                    db.KARTKI.Remove(model);
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
