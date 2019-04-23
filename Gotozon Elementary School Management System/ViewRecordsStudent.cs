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
    public partial class ViewRecordsStudent : Form
    {

        public ViewRecordsStudent()
        {
            InitializeComponent();
        }
        
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        StudentData st;
        private void ViewRecords_Load(object sender, EventArgs e)
        {
 
            long id = 118464000;

            for (long i = id; i < 118464000 + 1000; i++)
            {
                if (File.Exists("c:/Confidential/GESMIS/Student/" + i))
                {
                    FileStream fs = new FileStream("c:/Confidential/GESMIS/Student/" + i, FileMode.Open, FileAccess.Read);
                    BinaryFormatter b = new BinaryFormatter();
                    st = (StudentData)b.Deserialize(fs);
                    fs.Close();

                    string[] row0 = { st.id, st.name, st.gender};
                    dataGridView1.Rows.Add(row0);
                }
            }         
        }
    }
}
