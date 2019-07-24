using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft2Lab
{
    public class Person : IDisposable
    {
        private string _firstName;
        private string _lastName;
        private string _country;

        //flag for dispose
        private bool disposed = false;

        //setup component that works with files
        StreamReader sr;
        StreamWriter outputFile;

        public void ReadDetails(string fileName)
        {
            sr = new StreamReader(fileName);

            try
            {
                //A using block is exception safe, which means that if the code in the block throws an exception, the runtime will still dispose of the objects that are specified in the using statement.
                using (sr)
                {
                    string line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read." + e.Message);
            }
            finally
            {
                sr.Close();
                sr = null;
            }
            
        }

        public bool WriteDetails(string fileName)
        {
            bool result = false;
            outputFile = new StreamWriter(fileName);

            //create string array with line of the text to write
            string[] lines = { "The first name of the PERSON is: " + FirstName, "The last name of the PERSON is: " + LastName, "Their home country is: " + Country };

            try
            {
                //A using block is exception safe, which means that if the code in the block throws an exception, the runtime will still dispose of the objects that are specified in the using statement.
                using (outputFile)
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
                result = true;
            }
            catch (Exception e )
            {
                Console.WriteLine("This file could not be written. " + e.Message);
                result = false;
            }
            finally
            {
                outputFile.Close();
                outputFile = null;
            }
            return result;
        }

        public void Dispose()
        {
            
            Dispose(true);
            Console.WriteLine("Hello from dispose");
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose (bool disposing)
        {
            Console.WriteLine("Hello from overloaded dispose");
            if (!disposed)
            {
                if (disposing)
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                    if (outputFile != null)
                    {
                        outputFile.Close();
                    }
                }
            }
            disposed = true;
        }

        ~Person()
        {
            Dispose(false);
        }


        public Person(string fn, string ln, string country)
        {
            _firstName = fn;
            _lastName = ln;
            _country = country;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Country { get => _country; set => _country = value; }


    }
}
