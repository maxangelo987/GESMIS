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
    public partial class Student : Form
    {

        UserData us;

        public Student()
        {
            InitializeComponent();

         
            //GradeBox.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;


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


            switch (us.username)
            {
                case "grade6":
                    GradeBox.Text = "Grade 6";
                    break;
                case "grade5":
                    GradeBox.Text = "Grade 5";
                    break;
                case "grade4":
                    GradeBox.Text = "Grade 4";
                    break;
                case "grade3":
                    GradeBox.Text = "Grade 3";
                    break;
                case "grade2":
                    GradeBox.Text = "Grade 2";
                    break;
                case "grade1":
                    GradeBox.Text = "Grade 1";
                    break;
                case "kindergarten":
                    GradeBox.Text = "Kindergarten";
                    break;
            }

        }

        private void Student_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        StudentData st;

        private void button1_Click(object sender, EventArgs e)
        {
            st = new StudentData();
            st.id = EnrollmentBox.Text;
            st.grade = GradeBox.Text;
            st.name = NameBox.Text;
            st.address = AddressBox.Text;
           
            
            st.father = FatherBox.Text;
            st.gender = comboBox3.SelectedItem.ToString();
           
         
            st.contact = ContactBox.Text;
         
   
            st.pic = ProfilePic.Image;

            if (!Directory.Exists("C:/Confidentia/GESMIS/Student/"))
            {
                Directory.CreateDirectory("C:/Confidential/GESMIS/Student/");
            }
           
            try
            {
                if (File.Exists("C:/Confidential/GESMIS/Student/" + st.id))
                {
                    MessageBox.Show("This ID is already exist. Please allot another one.");
                }
                else if (EnrollmentBox.Text == "")
                {
                    MessageBox.Show("Teacher ID can not be empty!");
                }
                else
                {
                    FileStream fs = new FileStream("c:/Confidential/GESMIS/Student/" + st.id, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(fs, st);
                    fs.Close();
                    MessageBox.Show("Student Has Been Added Successfully,Thank You");
                    button2.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BranchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ContactBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                
                    File.Delete("c:/Confidential/GESMIS/Student/" +(textBox6.Text) );
                    MessageBox.Show(textBox7.Text + " Has Been Deleted From Our Database..!!!");
                    textBox6.Clear();
                    textBox5.Clear();
                    textBox10.Clear();
         
                
            }
            catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfilePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image files (*.jpg,*.png)|*.jpg;*.png|All files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {

                ProfilePic.Load(op.FileName);

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EnrollmentBox.Clear();
            NameBox.Clear();
            FatherBox.Clear();
            AddressBox.Clear();
            ContactBox.Clear();
            Box2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            st = new StudentData();
            st.id = textBox5.Text;
            st.name = textBox4.Text;
            st.father = textBox3.Text;
            st.gender = comboBox3.SelectedItem.ToString();

            st.address = textBox13.Text;
            st.contact = textBox1.Text;
            st.grade = comboBox2.SelectedItem.ToString();
          
          
            st.pic = pictureBox2.Image;

            if (!Directory.Exists("c:/Confidential/GESMIS/Student/"))
            {
                Directory.CreateDirectory("c:/Confidential/GESMIS/Student/");
            }
            try
            {
                    FileStream fs = new FileStream("c:/Confidential/GESMIS/Student/" +textBox5.Text, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(fs, st);
                    fs.Close();
                    MessageBox.Show("Student Has Been Updated Successfully,Thank You");
                    button3.PerformClick();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            comboBox3.SelectedIndex = 0;
           // textBox2.Clear();
            textBox1.Clear();
            textBox9.Clear();
           
            comboBox1.SelectedIndex = 0;
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            st = new StudentData();
            try
            {
                if (!File.Exists("c:/Confidential/GESMIS/Student/" + textBox5.Text))
                {
                    MessageBox.Show("Sorry The Id You Have Entered Is Not Valid");
                }
                else
                {
                    FileStream fs = new FileStream("c:/Confidential/GESMIS/Student/" + textBox5.Text, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    st = (StudentData)b.Deserialize(fs);
                    fs.Close();
                    textBox4.Text = st.name;
                    textBox3.Text = st.father;
                    comboBox1.SelectedItem = st.gender;
                    textBox13.Text = st.address;
                    textBox1.Text = st.contact;
                    comboBox2.SelectedItem = st.grade; 
                    pictureBox2.Image = st.pic;

                }   

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image files (*.jpg,*.png)|*.jpg;*.png|All files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {

                pictureBox2.Load(op.FileName);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            st = new StudentData();
            try
            {
                

                    FileStream fs = new FileStream("c:/Confidential/GESMIS/Student/" + textBox6.Text, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    st = (StudentData)b.Deserialize(fs);
                    fs.Close();
                    textBox7.Text = st.name;

                    

                    textBox10.Text = st.contact;
                    comboBox5.SelectedItem = st.grade;

                    pictureBox3.Image = st.pic;

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CertificateBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnrollmentBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FatherBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        }
    }
    

