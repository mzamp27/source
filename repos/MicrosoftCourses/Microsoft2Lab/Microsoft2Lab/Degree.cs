using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft2Lab
{
    public class Degree
    {

        public string DegreeType { get => degreeType; set => degreeType = value; }
        private string degreeType;
        private List<Course> courses;  

        public Degree(string degreetype) 
        {
            degreeType = degreetype;
            courses = new List<Course>();
        }

        public void addCourse(Course c)
        {
            courses.Add(c);
        }
        public void showCourses()
        {
            foreach (Course course in courses)
                Console.WriteLine(course.getName());
        }

    }
}
