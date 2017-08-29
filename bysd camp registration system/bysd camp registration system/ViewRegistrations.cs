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
    public partial class ViewRegistrations : Form
    {
        public ViewRegistrations()
        {
            InitializeComponent();
        }

        string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb";
        int i = 0;
        DataSet ds;
        OleDbConnection con;
        OleDbDataAdapter com;

        private void btnmenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();
        }



        private void ViewRegistrations_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(conString);
            com = new OleDbDataAdapter("Select * From Registered Where ID", con);


            ds = new DataSet();


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            com.Fill(ds, "Registered");

            if (ds.Tables[0].Rows.Count > 0) 
            {
                i = 0;
                recorddisplay.Text = ds.Tables[0].Rows[i]["ID"].ToString();
                statusdisplay.Text = ds.Tables[0].Rows[i]["Meal Card"].ToString();
                namedisplay.Text = ds.Tables[0].Rows[i]["First Name"].ToString();
                surnamedisplay.Text = ds.Tables[0].Rows[i]["Surname"].ToString();
                churchdisplay.Text = ds.Tables[0].Rows[i]["Church"].ToString();
                citydisplay.Text = ds.Tables[0].Rows[i]["Association"].ToString();
                categorydisplay.Text = ds.Tables[0].Rows[i]["Category"].ToString();
                roomdisplay.Text = ds.Tables[0].Rows[i]["Room"].ToString();
                celldisplay.Text = ds.Tables[0].Rows[i]["Cell"].ToString();
            }

            else
            {
                MessageBox.Show("No r4ecords to display");
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (i < ds.Tables[0].Rows.Count - 1)
            {
                i++;
                recorddisplay.Text = ds.Tables[0].Rows[i]["ID"].ToString();
                statusdisplay.Text = ds.Tables[0].Rows[i]["Meal Card"].ToString();
                namedisplay.Text = ds.Tables[0].Rows[i]["First Name"].ToString();
                surnamedisplay.Text = ds.Tables[0].Rows[i]["Surname"].ToString();
                churchdisplay.Text = ds.Tables[0].Rows[i]["Church"].ToString();
                citydisplay.Text = ds.Tables[0].Rows[i]["Association"].ToString();
                categorydisplay.Text = ds.Tables[0].Rows[i]["Category"].ToString();
                roomdisplay.Text = ds.Tables[0].Rows[i]["Room"].ToString();
                celldisplay.Text = ds.Tables[0].Rows[i]["Cell"].ToString();
            }
            else
            {
                MessageBox.Show("no more records to show, you have reached the last record!");
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (i == ds.Tables[0].Rows.Count - 1 || i != 0)
            {
                i--;
                recorddisplay.Text = ds.Tables[0].Rows[i]["ID"].ToString();
                statusdisplay.Text = ds.Tables[0].Rows[i]["Meal Card"].ToString();
                namedisplay.Text = ds.Tables[0].Rows[i]["First Name"].ToString();
                surnamedisplay.Text = ds.Tables[0].Rows[i]["Surname"].ToString();
                churchdisplay.Text = ds.Tables[0].Rows[i]["Church"].ToString();
                citydisplay.Text = ds.Tables[0].Rows[i]["Association"].ToString();
                categorydisplay.Text = ds.Tables[0].Rows[i]["Category"].ToString();
                roomdisplay.Text = ds.Tables[0].Rows[i]["Room"].ToString();
                celldisplay.Text = ds.Tables[0].Rows[i]["Cell"].ToString();
            }
            else
            {
                MessageBox.Show("No more recors to show, you have reached the first record!");
            }
        }




    }
}
