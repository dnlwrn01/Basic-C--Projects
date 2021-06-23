using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    class Person
    {
        //create props
        public string CompanyName { get; set; }
        public bool Admin { get; set; }

        //first constructor taking 2 args
        public Person(string compName, string rights)
        {
            //check admin rights & set prop value
            if (rights == "Y")
            {
                Admin = true;
            }
            else if (rights == "y")
            {
                Admin = true;
            }
            else
            {
                Admin = false;
            }

            CompanyName = compName;
        }

        //if rights == _blank, set value to "N" by default
        public Person(string compName) : this(compName, "N")
        {
           
        }
    }
}
