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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void btnmain_Click(object sender, EventArgs e)
        {
            MainMenu back = new MainMenu();
            this.Hide();
            back.Show();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb"))
            using (OleDbCommand Command = new OleDbCommand(" SELECT count (ID) from Registered as total", con))
            {
                con.Open();
                OleDbDataReader DB_Reader = Command.ExecuteReader();

                if (DB_Reader.HasRows)
                {
                    DB_Reader.Read();
                    int id = DB_Reader.GetInt32(0);
                    string idshow = id.ToString();

                    texttotal.Text = idshow;

                }
            }


            //counting males
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
            OleDbCommand Comm = new OleDbCommand("SELECT COUNT (*) from Registered Where Sex = 'Male' ", conn);
            int countm = 0;


            conn.Open();
            OleDbDataReader drr = Comm.ExecuteReader();
            drr.Read();

            countm = drr.GetInt32(0);
            string countnow = countm.ToString();
            maletext.Text = countnow;

            maletext.Text = countnow;


            //counting females
            OleDbConnection connn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
            OleDbCommand Commm = new OleDbCommand("SELECT COUNT (*) from Registered Where Sex = 'Female' ", connn);
            int countf = 0;


            connn.Open();
            OleDbDataReader drrr = Commm.ExecuteReader();
            drrr.Read();

            countf = drrr.GetInt32(0);
            string countfemale = countf.ToString();
            femaletext.Text = countfemale;

            femaletext.Text = countfemale;


            //counting bysd members
            OleDbConnection conmember = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
            OleDbCommand Commember = new OleDbCommand("SELECT COUNT (*) from Registered Where Category = 'BYSD member' ", conmember);
            int countmember = 0;


            conmember.Open();
            OleDbDataReader drmember= Commember.ExecuteReader();
            drmember.Read();

            countmember = drmember.GetInt32(0);
            string countmembers = countmember.ToString();
            textmember.Text = countmembers;
            
            textmember.Text = countmembers;



            //counting advisors and speakers
            OleDbConnection conex = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
            OleDbCommand Comex = new OleDbCommand("SELECT COUNT (*) from Registered Where Category = 'Advisor' AND 'Speaker' ", conex);
            int countex = 0;


            conex.Open();
            OleDbDataReader drex = Comex.ExecuteReader();
            drex.Read();

            countex = drex.GetInt32(0);
            string countexes = countex.ToString();
            textex.Text = countexes;

            textex.Text = countexes;

            //counting visitors
            OleDbConnection convisitor = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
            OleDbCommand Comvisitor = new OleDbCommand("SELECT COUNT (*) from Registered Where Category = 'Visitor(ex BYSD member)' ", convisitor);
            int countvisitor = 0;


            convisitor.Open();
            OleDbDataReader drvisitor = Comvisitor.ExecuteReader();
            drvisitor.Read();

            countvisitor = drvisitor.GetInt32(0);
            string countvisitors = countvisitor.ToString();
            textvisitor.Text = countvisitors;

            textvisitor.Text = countvisitors;

            //counting masvingo
            OleDbConnection conmas = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
            OleDbCommand Commas = new OleDbCommand("SELECT COUNT (*) from Registered Where Association = 'Masvingo' ", conmas);
            int countmass = 0;


            conmas.Open();
            OleDbDataReader drmas = Commas.ExecuteReader();
            drmas.Read();

            countmass = drmas.GetInt32(0);
            string countmas = countmass.ToString();
            masvingodisplay.Text = countmas;

            masvingodisplay.Text = countmas;


            //counting mutare
            OleDbConnection conmut = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
            OleDbCommand Commut = new OleDbCommand("SELECT COUNT (*) from Registered Where Association = 'Mutare' ", conmut);
            int countmut = 0;


            conmut.Open();
            OleDbDataReader drmut = Commut.ExecuteReader();
            drmut.Read();

            countf = drmut.GetInt32(0);
            string countmutt = countmut.ToString();
            mutaredisplay.Text = countmutt;

            mutaredisplay.Text = countmutt;


            //counting sanyati
            OleDbConnection consan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
            OleDbCommand Comsan = new OleDbCommand("SELECT COUNT (*) from Registered Where Association = 'Sanyati' ", consan);
            int countsan = 0;


            consan.Open();
            OleDbDataReader drsan = Comsan.ExecuteReader();
            drsan.Read();

            countsan = drsan.GetInt32(0);
            string countsans = countsan.ToString();
            sanyatidisplay.Text = countsans;

            sanyatidisplay.Text = countsans;



            //counting Victoria Falls
            OleDbConnection confalls = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
            OleDbCommand Comfalls = new OleDbCommand("SELECT COUNT (*) from Registered Where Association = 'Victoria Falls' ", confalls);
            int countfalls = 0;


            confalls.Open();
            OleDbDataReader drfalls = Comfalls.ExecuteReader();
            drfalls.Read();

            countfalls = drfalls.GetInt32(0);
            string countfall = countfalls.ToString();
            fallsdisplay.Text = countfall;

            fallsdisplay.Text = countfall;

            //counting zvishavane
            OleDbConnection conzvi = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\Registration.accdb");
            OleDbCommand Comzvi = new OleDbCommand("SELECT COUNT (*) from Registered Where Association = 'Zvishavane' ", conzvi);
            int countzvi = 0;


            conzvi.Open();
            OleDbDataReader drzvi = Comzvi.ExecuteReader();
            drzvi.Read();

            countzvi = drzvi.GetInt32(0);
            string countzvish = countzvi.ToString();
            zvishdisplay.Text = countzvish;

            zvishdisplay.Text = countzvish;

        }
    }
}
