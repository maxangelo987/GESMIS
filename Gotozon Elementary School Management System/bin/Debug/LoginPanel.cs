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
    public partial class LoginPanel : Form
    {
        StudentData st;
        TeacherData tc;
        UserData us;
        string[] collections = new string[200];

        public LoginPanel()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
            GESMIS.Visible = false;

            long id = 118464000;
            int k = 0;

            for (long i = id; i < 118464000 + 200; i++)
            {         
                collections[k] = i.ToString();
                k++;
           }  
        }

        public void process() {

            us = new UserData();
            us.user = "USER";
            us.username = textBox3.Text;


            if (!Directory.Exists("C:/Confidentia/GESMIS/User/"))
            {
                Directory.CreateDirectory("C:/Confidential/GESMIS/User/");
            }

            try
            {
                    FileStream fs = new FileStream("c:/Confidential/GESMIS/User/" + us.user, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(fs, us);
                    fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Welcome " + us.username);
        
            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (!File.Exists("C:/Confidential/GESMIS/Teacher/" + textBox3.Text))
            {
              MessageBox.Show("Invalid Username/Password");
            }

            else
            {

                    FileStream fs = new FileStream("C:/Confidential/GESMIS/Teacher/" + textBox3.Text, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    tc = (TeacherData)b.Deserialize(fs);
                    fs.Close();
                    if (textBox1.Text == tc.Password)
                    {
                        process();

                        if (tc.Teachingfield == "Head Teacher")
                        {
                            WelcomeHD wc = new WelcomeHD();
                            this.Hide();
                            wc.Show();
                            textBox1.Text = "";
                            textBox1.Text = "";
                        }

                        else
                        {
                            WelcomeO wc = new WelcomeO();
                            this.Hide();
                            wc.Show();
                            textBox1.Text = "";
                            textBox1.Text = "";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username/Password");
                    }
                
            }
        }

        private void LoginPanal_Load(object sender, EventArgs e)
        {
           comboBox1.Items.AddRange(collections);
        
        }


        public void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                pictureBox2.Visible = true;

            }
            else
            {
                pictureBox2.Visible = false;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Teacher rg = new Teacher();
            this.Hide();
            rg.Show();
              
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            st = new StudentData();
            try
            {
                if (!File.Exists("c:/Confidential/GESMIS/Student/" + comboBox1.Text))
                {
                    MessageBox.Show("Sorry The Id You Have Entered Is Not Valid");
                }
                else
                {
                    FileStream fs = new FileStream("c:/Confidential/GESMIS/Student/" + comboBox1.Text, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    st = (StudentData)b.Deserialize(fs);
                    fs.Close();
                    MessageBox.Show("Hello");
        
                }

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Resize(object sender, EventArgs e)
        {
            if (this.ParentForm.WindowState == FormWindowState.Normal &&
                this.WindowState == FormWindowState.Maximized)
            {
                this.ParentForm.WindowState = FormWindowState.Maximized;
            }

            if (this.ParentForm.WindowState == FormWindowState.Normal &&
                this.WindowState == FormWindowState.Minimized)
            {
                this.ParentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Resize(object sender, EventArgs e)
        {
            if (this.ParentForm.WindowState == FormWindowState.Normal &&
                this.WindowState == FormWindowState.Maximized)
            {
                this.ParentForm.WindowState = FormWindowState.Maximized;
            }

            if (this.ParentForm.WindowState == FormWindowState.Normal &&
                this.WindowState == FormWindowState.Minimized)
            {
                this.ParentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void labShow_Click(object sender, EventArgs e)
        {

        }


        private void labShow_MouseHover_1(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
        }

        private void labShow_MouseLeave_1(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
                if (textBox3.Text == "gesmis")
                {
                    if (textBox1.Text == "gesmis")
                    {
                        process();
                        this.Hide();
                        WelcomeHD wc = new WelcomeHD();
                        wc.Show();
                        textBox1.Text = "";
                        textBox3.Text = "";

                        // this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username/Password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username/Password");
                }
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = GESMIS.SelectedItem;
            GESMIS.Visible = false;
        }

     
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            // get the keyword to search
            string textToSearch = comboBox1.Text.ToLower();
            GESMIS.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox's Visible set to false if the keyword is empty
            //search
            string[] result = (from i in collections
                               where i.ToLower().Contains(textToSearch)
                               select i).ToArray();
            if (result.Length == 0)
                return; // return with listbox's Visible set to false if nothing found

            GESMIS.Items.Clear(); // remember to Clear before Add
            GESMIS.Items.AddRange(result);
            GESMIS.Visible = true; // show the listbox again
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = GESMIS.SelectedItem;
            GESMIS.Visible = false;
        }

        private void comboBox1_TextChanged_1(object sender, EventArgs e)
        {
            // get the keyword to search
            string textToSearch = comboBox1.Text.ToLower();
            GESMIS.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox's Visible set to false if the keyword is empty
            //search
            string[] result = (from i in collections
                               where i.ToLower().Contains(textToSearch)
                               select i).ToArray();
            if (result.Length == 0)
                return; // return with listbox's Visible set to false if nothing found

            GESMIS.Items.Clear(); // remember to Clear before Add
            GESMIS.Items.AddRange(result);
            GESMIS.Visible = true; // show the listbox again
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Developer wc = new Developer();
            this.Hide();
            wc.Show();
             
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                pictureBox1.Visible = true;

            }
            else
            {
                pictureBox1.Visible = false;
            }
        }
    }
}
