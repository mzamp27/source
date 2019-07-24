using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftClass2
{
    class Employee
    {
        private string empNumber;
        private string _firstName;
        private string lastName;
        private string address;


        //auto implemented properties
        //If you need to add logic to the get and set methods you need to expand into traditional style
        
        public string FirstName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("The employee number cannot be null");
                }
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
            
        }


        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Address { get { return this.address; } set => this.address = value;  }

        //traditional style to add if logic
        public string EmpNumber
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("The employee number cannot be null");
                }
                this.empNumber = value;
            }
            get
            {
                return this.empNumber;
            }
        }

      
       
    }
}
