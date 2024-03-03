using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamIo.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TeacherName { get; set; }
        public int TeacherId { get; set; }
        public double Fee { get; set; }
        public string Subject { get; set; }
        public List<Course> courses = new List<Course>();





    }
}
