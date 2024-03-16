namespace DesktopApp
{
    public partial class Trips : Form
    {
        public Trips()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

            Users users = new Users();
            users.Show();
            this.Hide();
        }

        private void btnRecommend_Click(object sender, EventArgs e)
        {

            Recommend recommend = new Recommend();
            recommend.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn login = new LogIn();
            login.Show();
        }
    }
}