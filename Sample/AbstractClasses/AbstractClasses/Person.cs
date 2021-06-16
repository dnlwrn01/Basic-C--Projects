using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Person
    {
        //define properties
        public string fName { get; set; }
        public string lName { get; set; }

        //create method
        public virtual void SayName()
        {
           
        }
        
    }
}
