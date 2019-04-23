using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace School_Management_System
{
    public partial class WelcomeHD : Form
    {
        UserData us;
        TeacherData tc;

        public WelcomeHD()
        {
            InitializeComponent();

            us = new UserData();
            try
            {
              
                    FileStream fs = new FileStream("c:/Confidential/GESMIS/User/" + "USER", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    us = (UserData)b.Deserialize(fs);
                    fs.Close();
              

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }


            

            switch (us.username) { 
                case "gesmis":
                    groupBox1.Text = "Account: Developer";
                    label8.Text = "GESMIS-DEVELOPER";
                    break;
                case "headteacher":
                    process();
                    groupBox1.Text = "Account: Head Teacher";
                    label8.Text = tc.Name;
                    pictureBox4.Image = tc.pic;
                    break;                 
            }       
        }

        public void process()
        {
            try
            {

                FileStream fs1 = new FileStream("c:/Confidential/GESMIS/Teacher/" + us.username, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter b1 = new BinaryFormatter();
                tc = (TeacherData)b1.Deserialize(fs1);
                fs1.Close();
            }

            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Teacher tc = new Teacher();
            tc.Show();      
        }

        private void label7_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ViewRecordsTeacher tc = new ViewRecordsTeacher();
            tc.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPanel lp = new LoginPanel();
            lp.Show();
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ViewRecordsStudent tc = new ViewRecordsStudent();
            tc.Show();
        }
    }
}
