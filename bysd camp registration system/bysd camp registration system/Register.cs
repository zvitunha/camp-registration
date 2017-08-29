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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            MainMenu cancel = new MainMenu();
            this.Hide();
            cancel.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {


            //check missing data if its a must




            //check rooms 

            string RoomIpi = roomcombo.Text;
            using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb"))
            {
                con.Open();

                using (OleDbCommand com = new OleDbCommand("SELECT Vacancy FROM Rooms WHERE Room = '"+RoomIpi+"' ", con))
                {
                    OleDbDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        int vacancyFor = int.Parse(dr["Vacancy"].ToString());

                        if (vacancyFor == 0)
                        {
                            MessageBox.Show("Room " + RoomIpi + " is already full! Please allocate another room!");
                            roomcombo.Text = "Allocate another room";
                        }

                        else //if room is not full it should then add record 
                        {
                            //variables declaration and initialisation
                            string name = nametext.Text;
                            string surname = surnametext.Text;
                            string sex = sexcombo.Text;
                            string church = churchtext.Text;
                            string city = citytext.Text;
                            string category = categorycombo.Text;
                            string cell = celltext.Text;
                            string email = emailtext.Text;
                            string room = roomcombo.Text;


                            //inserting records to database
                            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
                            OleDbCommand comm = new OleDbCommand("Command String", conn);
                            conn.Open();

                            comm.CommandText = "INSERT INTO Registered ([First Name],[Surname],[Sex],[Church],[Association],[Category],[Cell],[Email],[Room],[Meal Card]) VALUES ('" + name + "','" + surname + "','" + sex + "', '" + city + "','" + church + " Baptist Church','" + category + "','" + cell + "','" + email + "','" + room + "', 'Pending');";
                            comm.ExecuteNonQuery();

                            conn.Close();
                            conn.Dispose();




                            //reseting buttons
                            nametext.Clear();
                            surnametext.Clear();
                            churchtext.Clear();
                            categorycombo.Text = "Select Category";
                            celltext.Clear();
                            emailtext.Clear();



                            //now update new entry into the rooms table
                            OleDbConnection conupdate = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
                            OleDbCommand comupdate = new OleDbCommand("Command String", conupdate);
                            OleDbCommand comread = new OleDbCommand("SELECT Vacancy, Accomodate FROM Rooms Where Room = '"+roomcombo.Text+"'", conupdate);
                            conupdate.Open();

                            OleDbDataReader dr2 = comread.ExecuteReader();
                            dr2.Read();

                            int vacancy = int.Parse(dr["Vacancy"].ToString());

                            int vacancyy = vacancy - 1;

                            comupdate.CommandText = "UPDATE Rooms SET Vacancy='"+vacancyy+"' Where Room = '"+roomcombo.Text+"' ";
                            comupdate.ExecuteNonQuery();

                            conupdate.Close();
                            conupdate.Dispose();

                            MessageBox.Show("Record successfully added");



                        }
                    }

                }
                        
            }



           /** 
            //int vacancyFor = int.Parse

          if (vacancyFor == 0)
            {
                MessageBox.Show(room1 + "is full! Allocate another room");
                roomcombo.Text = "Allocate another room!";
            }
            



            else
            {

                //updating rooms
                OleDbConnection conupdate = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
                OleDbCommand comupdate = new OleDbCommand("Command String", conupdate);
                conupdate.Open();



                comupdate.CommandText = "UPDATE Registered SET Vacancy='" + newVacancyFor + "' Where 'Room = " + room1 + "' ";
                comupdate.ExecuteNonQuery();

                conupdate.Close();
                conupdate.Dispose();





                //variables declaration and initialisation
                string name = nametext.Text;
                string surname = surnametext.Text;
                string sex = sexcombo.Text;
                string church = churchtext.Text;
                string city = citytext.Text;
                string category = categorycombo.Text;
                string cell = celltext.Text;
                string email = emailtext.Text;
                string room = roomcombo.Text;


                //inserting records to database
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
                OleDbCommand com = new OleDbCommand("Command String", con);
                con.Open();

                com.CommandText = "INSERT INTO Registered ([First Name],[Surname],[Sex],[Church],[City],[Category],[Cell],[Email],[Room],[Meal Card]) VALUES ('" + name + "','" + surname + "','" + sex + "', '" + city + "','" + church + " Baptist Church','" + category + "','" + cell + "','" + email + "','" + room + "', 'Pending');";
                com.ExecuteNonQuery();

                con.Close();
                con.Dispose();

                MessageBox.Show("Record successfully added");


                //reseting buttons
                nametext.Clear();
                surnametext.Clear();
                churchtext.Clear();
                categorycombo.Text = "Select Category";
                celltext.Clear();
                emailtext.Clear();
                roomcombo.Text = "Choose Room";

            * **/

            }
        }
    }

