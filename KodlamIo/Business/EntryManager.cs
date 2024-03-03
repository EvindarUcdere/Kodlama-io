using KodlamIo.DataAccess.Abstracts;
using KodlamIo.DataAccess.Concretes;
using KodlamIo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamIo.Business
{
    internal class EntryManager
    {
        
        public void Entry()
        {
            Console.WriteLine("Welcome to kodlama.io");
            Console.WriteLine("Welcome to the system!");
            Console.Write("Are you a student or a teacher? Enter 'student' or 'teacher': ");
            string userType = Console.ReadLine().ToLower();

            if (userType == "student")
            {
                Console.Write("Do you have an account? Enter 'yes' or 'no': ");
                string hasAccount = Console.ReadLine().ToLower();

                if (hasAccount == "yes")
                {
                    // if the student has courses  shows the courses
                    Console.WriteLine("Displaying student courses...");
                    CourseDal course = new CourseDal();
                    foreach(var cour in course.courses) {
                        Console.WriteLine(cour.Name +"\n"+ cour.Subject + "\n"+ cour.TeacherName + "\n"+ cour.Fee);
                        Console.WriteLine("****************************************");
                        
                    }
                  
                }
                else if (hasAccount == "no")
                {
                    // creates aa new student account
                    Console.WriteLine("Creating a new student account...");
                    StudentDal student = new StudentDal();

                    
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            else if (userType == "teacher")
            {

                CourseDal course = new CourseDal();
                TeacherDal teacherDal = new TeacherDal();
                teacherEntry();
                Console.WriteLine("all courses");
                
                foreach (var cour in course.courses)
                {
                    Console.WriteLine(cour.Name + "\n" + cour.Subject + "\n" + cour.TeacherName + "\n" + cour.Fee);
                   

                }

            }
            else
            {
                Console.WriteLine("Invalid user type.");
            }
        }
        static bool teacherEntry() {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            CourseDal course = new CourseDal();
            TeacherDal teacherDal = new TeacherDal();
            foreach (var teacher in teacherDal.Teachers)
            {
                if (teacher.TeacherEmail == email && teacher.TeacherPasword == password)
                {
                    foreach (var cour in course.courses)
                    {
                        if (cour.TeacherId == teacher.TeacherId)
                        {
                            Console.WriteLine(cour.Name + "\n" + cour.Subject + "\n" + cour.TeacherName + "\n" + cour.Fee);
                            return true;
                           
                        }

                    }
                }
                else
                {
                    Console.WriteLine("you entered the wrong email and password");
                    return  teacherEntry();
                    
                }
            }
            return teacherEntry();
        }

      
    }
}
