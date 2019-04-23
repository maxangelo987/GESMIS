using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace School_Management_System
{
    public partial class ViewRecordsTeacher : Form
    {
        public ViewRecordsTeacher()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        TeacherData st;
        private void ViewRecordsTeacher_Load(object sender, EventArgs e)
        {
           
       
            string[] id =  {"kindergarten","grade1","grade2","grade3","grade4","grade5","grade6","headteacher"};

            for (int i = 7; i >= 0; i--)
            {
                //MessageBox.Show(id[i]);
                if (File.Exists("c:/Confidential/GESMIS/Teacher/" + id[i]))
                {
                    FileStream fs = new FileStream("c:/Confidential/GESMIS/Teacher/" + id[i], FileMode.Open, FileAccess.Read);
                    BinaryFormatter b = new BinaryFormatter();
                    st = (TeacherData)b.Deserialize(fs);
                    fs.Close();
                
                    string[] row0 = { st.Username, st.Name, st.Teachingfield, st.Gender, st.Address, st.Contact };
                    dataGridView1.Rows.Add(row0);
                    
                }
         
          }         
        
        }
    }
}
