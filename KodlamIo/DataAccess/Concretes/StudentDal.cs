using KodlamIo.DataAccess.Abstracts;
using KodlamIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamIo.DataAccess.Concretes
{
    internal class StudentDal : IStudent
    {
        List<BaseStudent> students = new List<BaseStudent>();
        public StudentDal() { 
          
            BaseStudent baseStudent1 = new BaseStudent();
            baseStudent1.Id = 1;
            baseStudent1.Name = "Evindar Üçdere";
            baseStudent1.Gmail = "evin@gmail.com";


            BaseStudent baseStudent2 = new BaseStudent();
            baseStudent2.Id = 2;
            baseStudent2.Name = "Ecem  Gezici";
            baseStudent2.Gmail = "ecem@gmail.com";


            BaseStudent baseStudent3 = new BaseStudent();
            baseStudent3.Id = 1;
            baseStudent3.Name = "Aysel Tüm";
            baseStudent3.Gmail = "aysel@gmail.com";


            BaseStudent baseStudent4 = new BaseStudent();
            baseStudent4.Id = 3;
            baseStudent4.Name = "Dilan Mutlu";
            baseStudent4.Gmail = "dilan@gmail.com";

            BaseStudent baseStudent5 = new BaseStudent();
            baseStudent5.Id = 4;
            baseStudent5.Name = "Hüseyin Karadere";
            baseStudent5.Gmail = "huseyin@gmail.com";
           students.Add(baseStudent1);
            students.Add(baseStudent2);
            students.Add(baseStudent3);   
            students.Add(baseStudent4);   
            students.Add(baseStudent5);
        }
        public StudentDal(String Name ,string gmail)
        {
            BaseStudent student= new BaseStudent();
            student.Id = students.Count();
            student.Name = Name;
            student.Gmail = gmail;
            students.Add(student);
        }

        public void Create(BaseStudent baseStudent)
        {   
            students.Add(baseStudent);
            Console.WriteLine($"{baseStudent.Name} student has been created.");
        }

        public void Delete(BaseStudent baseStudent)
        {
            BaseStudent studentToDelete = students.FirstOrDefault(s => s.Id == baseStudent.Id);

            if (studentToDelete != null)
            {
                students.Remove(studentToDelete);
                Console.WriteLine($"{studentToDelete.Name} student has been deleted.");
            }
            else
            {
                Console.WriteLine($"Student with ID {baseStudent.Id} not found.");
            }
        }
    }
}
