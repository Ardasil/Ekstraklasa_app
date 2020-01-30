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
    public partial class TEAMS : Form
    {
        DRUZYNY model = new DRUZYNY();
        public TEAMS()
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
            model.Id_druz = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Nazwa_druz = txtCol1.Text.Trim();
            model.Wlasciciel = txtCol2.Text.Trim();
            model.Siedziba = txtCol3.Text.Trim();
            model.Ilosc_rozegranych_meczy = System.Convert.ToInt32(txtCol4.Text.Trim());
            model.Punkty = System.Convert.ToInt32(txtCol5.Text.Trim());

            using (EkstraklasaEntities db = new EkstraklasaEntities())
            {
                if (model.Id_druz == 0) //Insert
                    db.DRUZYNY.Add(model);
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
                datGrid.DataSource = db.DRUZYNY.ToList<DRUZYNY>();
            }
        }

        private void datGrid_DoubleClick(object sender, EventArgs e)
        {
            if(datGrid.CurrentRow.Index != -1)
            {
                model.Id_druz = Convert.ToInt32(datGrid.CurrentRow.Cells["Id_druz"].Value);
                using (EkstraklasaEntities db = new EkstraklasaEntities())
                {
                    model = db.DRUZYNY.Where(x => x.Id_druz == model.Id_druz).FirstOrDefault();
                    txtCol1.Text = model.Nazwa_druz;
                    txtCol2.Text = model.Wlasciciel;
                    txtCol3.Text = model.Siedziba;
                    txtCol4.Text = System.Convert.ToString(model.Ilosc_rozegranych_meczy);
                    txtCol5.Text = System.Convert.ToString(model.Punkty);
                }
                btnSave.Text = "Update";
                btnDel.Enabled = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Na pewno chcesz usunąć ten rekord?","Usunięcie rekordu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (EkstraklasaEntities db = new EkstraklasaEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    
                        db.DRUZYNY.Attach(model);
                        db.DRUZYNY.Remove(model);
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
