using KodlamIo.DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamIo.Entities
{
    internal class BaseTeacher
    {
        public int TeacherId {  get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; } 
        
        public string TeacherEmail { get; set; }
        public string TeacherPasword { get; set; }

    }
}
