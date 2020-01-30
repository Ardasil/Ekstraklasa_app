using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ekstraklasa
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L3NRFTC;Initial Catalog=Ekstraklasa;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM Login WHERE LOGIN='" + txtLogin.Text + "' AND PASSWORD='" + txtPass.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MAIN ss = new MAIN();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Podano błędne dane logowania");
            }

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            txtPass.MaxLength = 20;
        }
    }
}


