using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace School_Management_System
{
    [Serializable]
    class TeacherData
    {
        public string Id { get; set; }
        public string Trainer { get; set; }
        public string Experience { get; set; }
        
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Teachingfield { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public Image pic { set; get; }


    }
}
