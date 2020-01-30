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
    public partial class PLAYERS : Form
    {
        PILKARZE model = new PILKARZE();
        public PLAYERS()
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
            txtCol1.Text = txtCol2.Text = txtCol3.Text = txtCol4.Text = txtCol5.Text = txtCol6.Text = txtCol7.Text = txtCol8.Text = txtCol9.Text = "";
            btnSave.Text = "Save";
            btnDel.Enabled = false;
            model.Id_pilkarze = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Id_druz = System.Convert.ToInt32(txtCol1.Text.Trim()); 
            model.Imie_pilk = txtCol2.Text.Trim(); 
            model.Nazwisko_pilk = txtCol3.Text.Trim(); 
            model.Nazwa_druz_pilk = txtCol4.Text.Trim(); 
            model.Wiek_pilk = System.Convert.ToInt32(txtCol5.Text.Trim()); 
            model.Ilosc_meczy_pilk = System.Convert.ToInt32(txtCol6.Text.Trim()); 
            model.Ilosc_strzelonych_goli_pilk = System.Convert.ToInt32(txtCol7.Text.Trim()); 
            model.Ilosc_wpuszczonych_goli_pilk = System.Convert.ToInt32(txtCol8.Text.Trim()); 
            model.Specjalizacja = txtCol9.Text.Trim();

            using (EkstraklasaEntities db = new EkstraklasaEntities())
            {
                if (model.Id_pilkarze == 0) //Insert
                    db.PILKARZE.Add(model);
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
                datGrid.DataSource = db.PILKARZE.ToList<PILKARZE>();
            }
        }

        private void datGrid_DoubleClick(object sender, EventArgs e)
        {
            if (datGrid.CurrentRow.Index != -1)
            {
                model.Id_pilkarze = Convert.ToInt32(datGrid.CurrentRow.Cells["Id_pilkarze"].Value);
                using (EkstraklasaEntities db = new EkstraklasaEntities())
                {
                    model = db.PILKARZE.Where(x => x.Id_pilkarze == model.Id_pilkarze).FirstOrDefault();
                    txtCol1.Text = System.Convert.ToString(model.Id_druz); 
                    txtCol2.Text = model.Imie_pilk; 
                    txtCol3.Text = model.Nazwisko_pilk; 
                    txtCol4.Text = model.Nazwa_druz_pilk; 
                    txtCol5.Text = System.Convert.ToString(model.Wiek_pilk); 
                    txtCol6.Text = System.Convert.ToString(model.Ilosc_meczy_pilk); 
                    txtCol7.Text = System.Convert.ToString(model.Ilosc_strzelonych_goli_pilk); 
                    txtCol8.Text = System.Convert.ToString(model.Ilosc_wpuszczonych_goli_pilk); 
                    txtCol9.Text = model.Specjalizacja;
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

                    db.PILKARZE.Attach(model);
                    db.PILKARZE.Remove(model);
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
