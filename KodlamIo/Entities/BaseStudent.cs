using KodlamIo.DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamIo.Entities
{
    internal class BaseStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gmail { get; set; }
        //public List<Course> StudentCourses { get; set; }
    }
}
