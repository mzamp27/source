using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft2Lab
{
    // Subclasses should implement the disposable pattern as follows:

    //They must override Dispose(Boolean) and call the base class Dispose(Boolean) implementation.

    //They can provide a finalizer if needed.The finalizer must call Dispose(false).


    public class Student : Person
    {
        private static int studentId = 1;
        private bool disposed;

        public void PerformAdditionalWork()
        {
            // Every method should have this check, so we still need to handle this
            if (this.disposed)
            {
                throw new ObjectDisposedException("Student Problem");
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



        public Student(string fn, string ln, string country) : base(fn, ln, country)
        {
        
        StudentId = studentId;
        studentId++;

        }

        public int StudentId { get; set; }


        public int TakeTest()
        {
            Random rnd = new Random();
            int testgrade = rnd.Next(50, 100);
            Console.WriteLine("Your grade is: {0}", testgrade);
            return testgrade;
        }

        

    }
}
