using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft2Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //UProgram U1 = new UProgram("Information Technology");
            //Console.WriteLine(U1.Major);



            //Student S1 = new Student("Mark", "Zuck", "USA");
            //Student S2 = new Student("Todd", "Peng", "CHINA");
            //Student S3 = new Student("Sally", "Erin", "UK");
            //Teacher T1 = new Teacher("John", "Harrison", "USA", 80000);


            //Course C1 = new Course("Intro to C#", 30);
            //C1.setTeacher(T1);
            //Console.WriteLine(C1.getTeacherName());
            //Console.WriteLine("Course Title: " + C1.getName() + " " + C1.getCourseNumber());
            //Console.WriteLine("Capacity: " + C1.getCapacity());
            //Console.WriteLine("Slots available: " + (C1.getCapacity() - C1.getCurrentEnrollment()));

            //C1.addStudent(S1);
            //C1.addStudent(S2);
            //C1.addStudent(S3);
            //Console.WriteLine(C1.getCurrentEnrollment());
            //C1.getStudentArray();

            //Degree D1 = new Degree("Bachelor");
            //D1.addCourse(C1);
            //D1.showCourses();

            //U1.addDegree(D1);
            //U1.showDegrees();

            //S1.TakeTest();
            //T1.GradeTest();

            //C1.removeStudent(S1);

            //Person P1 = new Person("Tom", "Thumb", "England");
            //P1.WriteDetails("TextFile1.txt");
            //P1.ReadDetails("TextFile1.txt");
            //P1.Dispose();

            Student S4 = new Student("Jerry", "Posh", "USA");
            S4.WriteDetails("TextFile1.txt");
            S4.ReadDetails("TextFile1.txt");
            S4.Dispose();




            


        }
    }
}
