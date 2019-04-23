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
    public partial class WelcomeO : Form
    {
        UserData us;
        TeacherData tc;

        public WelcomeO()
        {
            InitializeComponent();

            us = new UserData();
            tc = new TeacherData();
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


            switch (us.username)
            {
                case "grade6":
                    groupBox1.Text = "Account: Grade 6";
                    label3.Text = "View Records\n   (Grade 6)";
                    TeacherProfilePic1.Image = tc.pic;
                    label5.Text = tc.Name;
                    break;
                case "grade5":
                    groupBox1.Text = "Account: Grade 5";
                    label3.Text = "View Records\n   (Grade 5)";
                    TeacherProfilePic1.Image = tc.pic;
                    label5.Text = tc.Name;
                    break;
                case "grade4":
                    groupBox1.Text = "Account: Grade 4";
                    label3.Text = "View Records\n   (Grade 4)";
                    TeacherProfilePic1.Image = tc.pic;
                    label5.Text = tc.Name;
                    break;
                case "grade3":
                    groupBox1.Text = "Account: Grade 3";
                    label3.Text = "View Records\n   (Grade 3)";
                    TeacherProfilePic1.Image = tc.pic;
                    label5.Text = tc.Name;
                    break;
                case "grade2":
                    groupBox1.Text = "Account: Grade 2";
                    label3.Text = "View Records\n   (Grade 2)";
                    TeacherProfilePic1.Image = tc.pic;
                    label5.Text = tc.Name;
                    break;
                case "grade1":
                    groupBox1.Text = "Account: Grade 1";
                    label3.Text = "View Records\n   (Grade 1)";
                    TeacherProfilePic1.Image = tc.pic;
                    label5.Text = tc.Name;
                    break;
                case "kindergarten":
                    groupBox1.Text = "Account: Kindergarten";
                    label3.Text = "View Records\n(Kindergarten)";
                    TeacherProfilePic1.Image = tc.pic;
                    label5.Text = tc.Name;
                    break;
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Show();
        }

        private void Welcome1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ViewRecordsStudent tc = new ViewRecordsStudent();
            tc.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void TeacherProfilePic1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPanel lp = new LoginPanel();
            lp.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Grade lp = new Grade();
            lp.Show();
        }
    }
}
