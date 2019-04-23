using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace School_Management_System
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
            TrainerBox.SelectedIndex = 0;
            teachingfield.SelectedIndex = 0;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            TeacherPassword.UseSystemPasswordChar = false;
            TeacherPassword2.UseSystemPasswordChar = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProfilePic_Click(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void CertificateBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ContactBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FatherBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnrollmentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        

        private void TeacherProfilePic1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeacherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeacherProfilePic1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image files (*.jpg,*.png)|*.jpg;*.png|All files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {

                TeacherProfilePic1.Load(op.FileName);

            }
        }

        private void TeacherId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeacherId_Enter(object sender, EventArgs e)
        {

        }

        TeacherData tc;
        private void button3_Click(object sender, EventArgs e)
        {
            tc = new TeacherData();
            tc.Username = TeacherUsername.Text;
            tc.Password = TeacherPassword.Text;
            tc.Name = TeacherName.Text;
            tc.Gender = radioButton1.Checked ? "Male" : "Female";
            tc.Address = AddressBox.Text;
            tc.Contact = ContactBox.Text;
            tc.Teachingfield = TrainerBox.SelectedItem.ToString();
            tc.pic = TeacherProfilePic1.Image;
            TeacherProfilePic1.Show();

           
            if (!Directory.Exists("C:/Confidential/GESMIS/Teacher/"))
            {
                Directory.CreateDirectory("C:/Confidential/GESMIS/Teacher/");
            }
            try
            {
                if (File.Exists("C:/Confidential/GESMIS/Teacher/" + tc.Username))
                {
                    MessageBox.Show("This Id  Is Already Exist...Sorry");
                }
                else if (TeacherUsername.Text == "")
                {
                    MessageBox.Show("Teacher Id Can Not Be Empty..!!!");
                }
                else
                {

                    FileStream fs = new FileStream("C:/Confidential/GESMIS/Teacher/" + tc.Username, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(fs, tc);
                    fs.Close();
                    MessageBox.Show("Teacher Has Been Added Successfully... Thank You...!!!");
                    button2.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPanel lp = new LoginPanel();
            lp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!File.Exists("C:/Confidential/GESMIS/Teacher/" + TeacherUsername2.Text))
            {
                MessageBox.Show("Sorry Invalid Id...!!!");
            }

            else
            {
                try
                {
                    FileStream fs = new FileStream("C:/Confidential/GESMIS/Teacher/" + TeacherUsername2.Text, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    tc = (TeacherData)b.Deserialize(fs);
                    fs.Close();
                    TeacherUsername2.Text = tc.Username;
                    TeacherPassword2.Text = tc.Password;
                    TeacherName2.Text = tc.Name;
                    radioButton4.Checked = tc.Gender.Equals("Male") ? true : false;
                    radioButton3.Checked = tc.Gender.Equals("Female") ? true : false;
                    teacherAddress2.Text = tc.Address;
                    teacherContact2.Text = tc.Contact;
                    teachingfield.SelectedItem = tc.Teachingfield;
                    TeacherProfilePic2.Image = tc.pic;
                    TeacherProfilePic2.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
  
        }

        private void button7_Click(object sender, EventArgs e)
        {

            tc.Username = TeacherUsername2.Text;
            tc.Password = TeacherPassword2.Text;
            tc.Name = TeacherName2.Text;
            tc.Gender = radioButton4.Checked ? "Male" : "Female";
            tc.Address = teacherAddress2.Text;
            tc.Contact = teacherContact2.Text;

            tc.Teachingfield = teachingfield.SelectedItem.ToString(); 
            tc.pic = TeacherProfilePic2.Image;

            try
            {
                FileStream fs = new FileStream("C:/Confidential/GESMIS/Teacher/" + TeacherUsername2.Text, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(fs, tc);
                fs.Close();
                MessageBox.Show("Teacher Has Been Updated Successfully... Thank You...!!!");
                button5.PerformClick();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            TeacherUsername2.Clear();
            TeacherPassword2.Clear();
            radioButton4.Checked = true;
            TeacherName2.Clear();
            teacherAddress2.Clear();
            teacherContact2.Clear();
            teachingfield.SelectedIndex = 0;
            TeacherProfilePic2.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!File.Exists("C:/Confidential/GESMIS/Teacher/" + Teacher_Username.Text))
            {
                MessageBox.Show("Sorry Invalid Id...!!!");
                button8.PerformClick();
            }
            else
            {
                try
                {
                    FileStream fs = new FileStream("C:/Confidential/GESMIS/Teacher/" + Teacher_Username.Text, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    tc = (TeacherData)b.Deserialize(fs);
                    fs.Close();
                    Teacher_Username.Text = tc.Username;

                    TeacherName3.Text = tc.Name;
                    textBox6.Text = tc.Address;
                    Contact3.Text = tc.Contact;
                    TeacherProfilePic3.Show();
                    TeacherProfilePic3.Image = tc.pic;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            TeacherUsername.Clear();
            TeacherPassword.Clear();
            TeacherName.Clear();
            AddressBox.Clear();
            ContactBox.Clear();
            TeacherProfilePic1.Hide();
            TrainerBox.SelectedIndex = 0;
        }

        private void TeacherProfilePic2_Click(object sender, EventArgs e)
        {
           
        }

       
        private void TeacherProfilePic2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            
            op.Filter = "Image files (*.jpg,*.png)|*.jpg;*.png|All files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                TeacherProfilePic2.Load(op.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("C:/Confidential/GESMIS/Teacher/" + Teacher_Username.Text);
                MessageBox.Show("Trainer Record Has Been Deleted From Our Database");
                button8.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Teacher_Username.Clear();
            TeacherName3.Clear();
            textBox6.Clear();
            Contact3.Clear();
            TeacherProfilePic3.Hide();
        }

        private void TeacherProfilePic1_Click_3(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image files (*.jpg,*.png)|*.jpg;*.png|All files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                TeacherProfilePic1.Load(op.FileName);
            }
        }

        private void teachingfield_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void labShow_MouseHover(object sender, EventArgs e)
        {
            TeacherPassword.UseSystemPasswordChar = true;
        }

        private void labShow_MouseLeave(object sender, EventArgs e)
        {
            TeacherPassword.UseSystemPasswordChar = false;
        }

        private void labShow_Click(object sender, EventArgs e)
        {

        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            TeacherPassword2.UseSystemPasswordChar = true;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            TeacherPassword2.UseSystemPasswordChar = false;
        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }
    }
}

