using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft2Lab
{
       
    public class Course
    {
        private string CourseName; //Name of course
        private Student[] students; //Declare array
        private int capacity; //Number of students allowed in course
        private int courseNumber;
        private Teacher CourseTeacher;

        private static int currentEnrollment; //number of students enrolled
        private static int numberOfCourses = 1; //Number of courses created so far

        //Array on one line Object[] myObjArray = new Object[5] { 26, 27, 28, 29, 30 };
        //Constructor
        public Course(string courseName, int cap, int currentenrollment = 0)
        {
            CourseName = courseName;
            capacity = cap;
            students = new Student[capacity]; //Create array
            currentEnrollment = currentenrollment;
            courseNumber = numberOfCourses;
            numberOfCourses++;
        }

        //Get and set methods
        public string getName()
        {
            return CourseName;
        }
        public void setName(String newName)
        {
            CourseName = newName;
        }
        public int getCapacity()
        {
            return capacity;
        }
        public void setCapacity(int newCapacity)
        {
            capacity = newCapacity;
        }
        public int getCurrentEnrollment()
        {
            return currentEnrollment;
        }
        public int getCourseNumber()
        {
            return courseNumber;
        }
        public void getStudentArray()
        {
            foreach (Student student in students)
                if (student != null)
                    Console.WriteLine(student.LastName);
                else
                    break;
        }
        public string getTeacherName()
        {
            return CourseTeacher.LastName;
        }
        public void setTeacher(Teacher t)
        {
            CourseTeacher = t;
        }



        //Method to add a student (s) to the course and return true if added and false if not
        public bool addStudent(Student s)
        {
            if (currentEnrollment <= capacity)
            {
                students[currentEnrollment] = s;
                currentEnrollment++;
                return true;
            }
            else
            {
                return false;
            }
        }


        //Method to remove student from a class
        public bool removeStudent(Student s)
        {
            
            for (int i = 0; i < capacity; i++)
            {
                if (students[i] == s)
                {                   
                    Console.WriteLine("Student {0} {1} removed successfully!", students[i].FirstName, students[i].LastName);
                    students[i] = null;
                    currentEnrollment--;
                    return true;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Student {0} not found.", s);
            return false;
            
            
        }

    }
}
