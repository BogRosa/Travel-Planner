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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            Trips trips = new Trips();
            trips.Show();
            this.Close();
        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {

            Recommend recommend = new Recommend();
            recommend.Show();
            this.Close();
        }
    }
}
