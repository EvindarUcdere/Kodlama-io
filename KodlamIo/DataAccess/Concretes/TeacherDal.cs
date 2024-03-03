using KodlamIo.DataAccess.Abstracts;
using KodlamIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamIo.DataAccess.Concretes
{
    internal class TeacherDal : ITeacher
    {   public List<BaseTeacher> Teachers = new List<BaseTeacher>();
        public TeacherDal() {
            BaseTeacher baseTeacher1 = new BaseTeacher();
            baseTeacher1.TeacherId = 1;
            baseTeacher1.TeacherFirstName = "Mehmet";
            baseTeacher1.TeacherLastName = "Can";
            baseTeacher1.TeacherEmail = "MehmetCan@gmail.com";
            baseTeacher1.TeacherPasword = "1345";
            baseTeacher1.TeacherId = 3;

            BaseTeacher baseTeacher2 = new BaseTeacher();
            baseTeacher2.TeacherId = 1;
            baseTeacher2.TeacherFirstName = "Evindar";
            baseTeacher2.TeacherLastName = "Üçdere";
            baseTeacher2.TeacherEmail = "Evindar@gmail.com";
            baseTeacher2.TeacherPasword = "1345Evin";
            baseTeacher2.TeacherId = 2;

            BaseTeacher baseTeacher3 = new BaseTeacher();
            baseTeacher3.TeacherId = 1;
            baseTeacher3.TeacherFirstName = "Engin";
            baseTeacher3.TeacherLastName = "Demiroğ";
            baseTeacher3.TeacherEmail = "demirogengin@gmail.com";
            baseTeacher3.TeacherPasword = "1345demiroğ";
            baseTeacher3.TeacherId = 4;


            BaseTeacher baseTeacher4 = new BaseTeacher();
            baseTeacher4.TeacherId = 1;
            baseTeacher4.TeacherFirstName = "Engin";
            baseTeacher4.TeacherLastName = "Demir";
            baseTeacher4.TeacherEmail = "engindemir@gmail.com";
            baseTeacher4.TeacherPasword = "1345Demir";
            baseTeacher4.TeacherId = 1;

            Teachers.Add(baseTeacher1 );
            Teachers.Add(baseTeacher2);
            Teachers.Add(baseTeacher3);
            Teachers.Add(baseTeacher4);

        }
        public void Create(BaseTeacher baseTeacher)
        {
            Console.WriteLine("To register new learners who want to teach in the system");
            Teachers.Add(baseTeacher);
        }

        public void Delete(BaseTeacher baseTeacher)
        {
            Teachers.Remove(baseTeacher);    

        }
    }
}
