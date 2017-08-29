using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BYSD_Camp_Registration_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Registration register = new Registration();
            this.Hide();
            register.Show();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ViewRegistrations view = new ViewRegistrations();
            this.Hide();
            view.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Records from this page may be inaccurate, You can read actual records from the database");
            AccomodationManagement accomodation = new AccomodationManagement();
            this.Hide();
            accomodation.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Statistics statistics = new Statistics();
            this.Hide();
            statistics.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

     
    }
}
