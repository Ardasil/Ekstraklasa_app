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
    public partial class MATCHES : Form
    {

        SPOTKANIA model = new SPOTKANIA();
        public MATCHES()
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
            model.Id_gospo = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Id_druz = System.Convert.ToInt32(txtCol1.Text.Trim());
            model.DRU_Id_druz = System.Convert.ToInt32(txtCol2.Text.Trim());
            model.Data = DateTime.Parse(txtCol3.Text.Trim());
            model.Godzina = TimeSpan.Parse(txtCol4.Text.Trim());
            model.Miejsce = txtCol5.Text.Trim();
            model.Wynik_gospo = System.Convert.ToInt32(txtCol6.Text.Trim());
            model.Wynik_gosc = System.Convert.ToInt32(txtCol7.Text.Trim());

            using (EkstraklasaEntities db = new EkstraklasaEntities())
            {
                if (model.Id_gospo == 0) //Insert
                    db.SPOTKANIA.Add(model);
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
                datGrid.DataSource = db.SPOTKANIA.ToList<SPOTKANIA>();
            }
        }

        private void datGrid_DoubleClick(object sender, EventArgs e)
        {
            if (datGrid.CurrentRow.Index != -1)
            {
                model.Id_gospo = Convert.ToInt32(datGrid.CurrentRow.Cells["Id_gospo"].Value);
                using (EkstraklasaEntities db = new EkstraklasaEntities())
                {
                    model = db.SPOTKANIA.Where(x => x.Id_gospo == model.Id_gospo).FirstOrDefault();
                    txtCol1.Text = System.Convert.ToString(model.Id_druz);
                    txtCol2.Text = System.Convert.ToString(model.DRU_Id_druz);
                    txtCol3.Text = System.Convert.ToString(model.Data);
                    txtCol4.Text = System.Convert.ToString(model.Godzina);
                    txtCol5.Text = model.Miejsce;
                    txtCol6.Text = System.Convert.ToString(model.Wynik_gospo);
                    txtCol7.Text = System.Convert.ToString(model.Wynik_gosc);
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

                        db.SPOTKANIA.Attach(model);
                    db.SPOTKANIA.Remove(model);
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
