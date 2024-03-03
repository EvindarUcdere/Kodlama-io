using KodlamIo.DataAccess.Abstracts;
using KodlamIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamIo.DataAccess.Concretes
{
    internal class CourseDal : Abstracts.ICourseDal

    {   public List<Course> courses=new List<Course>();
        public CourseDal()
        {

           Course course1 =new Course();
            course1.Id = 1;
            course1.Name = "2024 c# course";
            course1.TeacherName = "Engin demiroğ";
            course1.Fee = 0;
            course1.Subject = "Programing and algorithms by C#";
            course1.TeacherId = 4;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java course";
            course2.TeacherName = "Mehmet Can";
            course2.Fee = 0;
            course2.Subject = "Programing and algorithms by Java";
            course2.TeacherId = 3;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Sql course";
            course3.TeacherName = "Evindar Üçdere";
            course3.Fee = 0;
            course3.Subject = "all about Sql";
            course3.TeacherId = 2;

            Course course4 = new Course();
            course4.Id = 4;
            course4.Name = "c course";
            course4.TeacherName = "Engin Demir";
            course4.Fee = 0;
            course4.Subject = "Programing and algorithms by C";
            course4.TeacherId = 1;
            courses.Add(course1);
            courses.Add(course2);
            courses.Add(course3);
            courses.Add(course4);



        }
        public void Add(ICourseDal courseDal)
        {
            courses.Add((Course)courseDal);
        }

        public void Delete(ICourseDal courseDal)
        {
            if (courseDal is Course courseToDelete)
            {
                Course courseToRemove = courses.FirstOrDefault(c => c.Id == courseToDelete.Id);

                if (courseToRemove != null)
                {
                    courses.Remove(courseToRemove);
                    Console.WriteLine($"{courseToRemove.Name} course has been deleted.");
                }
                else
                {
                    Console.WriteLine($"Course with ID {courseToDelete.Id} not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid course type.");
            }
        }

        public void Update(ICourseDal courseDal)
        {
            if (courseDal is Course updatedCourse)
            {
                Course existingCourse = courses.FirstOrDefault(c => c.Id == updatedCourse.Id);

                if (existingCourse != null)
                {
                    existingCourse.Name = updatedCourse.Name;
                    existingCourse.TeacherName = updatedCourse.TeacherName;
                    existingCourse.Fee = updatedCourse.Fee;
                    existingCourse.Subject = updatedCourse.Subject;

                    Console.WriteLine($"{existingCourse.Name} course has been updated.");
                }
                else
                {
                    Console.WriteLine($"Course with ID {updatedCourse.Id} not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid course type.");
            }
        }
    }
}
