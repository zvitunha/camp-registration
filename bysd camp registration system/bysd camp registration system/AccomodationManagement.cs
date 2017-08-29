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
    public partial class AccomodationManagement : Form
    {
        public AccomodationManagement()
        {
            InitializeComponent();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            MainMenu back = new MainMenu();
            this.Hide();
            back.Show();
        }

        private void AccomodationManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationDataSet1.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.registrationDataSet1.Rooms);
        }
    }
}
