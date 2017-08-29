using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BYSD_Camp_Registration_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //login credentials entered by user
            string username = usertext.Text;
            string password = pwdtext.Text;

            OleDbConnection con;
            OleDbCommand com;
            OleDbDataReader dr;

            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
            com = new OleDbCommand("SELECT * FROM Users WHERE Username AND Password", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            dr = com.ExecuteReader();
            dr.Read();

            string usernameDB = dr["Username"].ToString();
            string passwordDB = dr["Password"].ToString();

            dr.Close();
            con.Close();
            //connecting to the database with usernames and pwd's
            //now showing the main menu
            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();
        }

        
    }
}
