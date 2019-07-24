using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft2Lab
{
    public class UProgram
    {
        private string _Major;
        private List<Degree> degrees; 
        public string Major { get => _Major; set => _Major = value; }

        public UProgram(string major)
        {
            _Major = major;
            degrees = new List<Degree>();
        }

        public void addDegree(Degree d)
        {
            degrees.Add(d);
        }
        public void showDegrees()
        {
            foreach (Degree degree in degrees)
                Console.WriteLine(degree.DegreeType);
        }

    }
}
