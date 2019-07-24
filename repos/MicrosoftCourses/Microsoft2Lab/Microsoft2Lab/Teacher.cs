using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft2Lab
{
    public class Teacher : Person
    {
        private bool disposed;

        public void PerformAdditionalWork()
        {
            // Every method should have this check, so we still need to handle this
            if (this.disposed)
            {
                throw new ObjectDisposedException("Teacher Problem");
            }
            // Do some work...
        }

        protected override void Dispose(bool disposing)
        {
            // We DO still need to track whether we've been disposed correctly.
            this.disposed = true;
            // Call our base Dispose method
            base.Dispose(disposing);
        }
        private int salary;
        public Teacher(string fn, string ln, string country) : base(fn, ln, country)
        {            
        }

        public Teacher(string fn, string ln, string country, int sal) : base(fn, ln, country)
        {
            salary = sal;
        }

        public int Salary { get => salary; set => salary = value; }

        public bool GradeTest()
        {
            Console.WriteLine("Checks values in test object returns true if passed");
            return true;
        }



    }


    

}
