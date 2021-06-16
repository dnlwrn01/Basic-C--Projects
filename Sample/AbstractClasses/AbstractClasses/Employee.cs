using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Employee : Person, IQuittable
    {
        //override method
        public override void SayName()
        {
            //write full name
            Console.WriteLine(fName + " " + lName);
            base.SayName();
        }

        //define quit() method
        public void Quit()
        {
            Console.WriteLine("I Quit");
        }



    }
}
