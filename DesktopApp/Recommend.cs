using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Recommend : Form
    {
        public Recommend()
        {
            InitializeComponent();
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            Trips trips = new Trips();
            trips.Show();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

            Users users = new Users();
            users.Show();
            this.Close();
        }
    }
}
