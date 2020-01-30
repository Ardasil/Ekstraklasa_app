using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekstraklasa
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDruzyny_Click(object sender, EventArgs e)
        {
            this.Hide();
            TEAMS ss = new TEAMS();
            ss.Show();
        }

        private void btnBramki_Click(object sender, EventArgs e)
        {
            this.Hide();
            GOALS ss = new GOALS();
            ss.Show();
        }

        private void btnKartki_Click(object sender, EventArgs e)
        {
            this.Hide();
            CARDS ss = new CARDS();
            ss.Show();

        }

        private void btnPilkarze_Click(object sender, EventArgs e)
        {
            this.Hide();
            PLAYERS ss = new PLAYERS();
            ss.Show();
        }

        private void btnSedziowie_Click(object sender, EventArgs e)
        {
            this.Hide();
            REFEREES ss = new REFEREES();
            ss.Show();
        }

        private void btnSpotkania_Click(object sender, EventArgs e)
        {
            this.Hide();
            MATCHES ss = new MATCHES();
            ss.Show();
        }

        private void btnTrenerzy_Click(object sender, EventArgs e)
        {
            this.Hide();
            COACHES ss = new COACHES();
            ss.Show();
        }
    }
}
