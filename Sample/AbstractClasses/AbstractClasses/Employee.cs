using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    
    public class Employee : Person, IQuittable
    {
        // create id property
        public int Id { get; set; }

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

        //create operator overload method for '==' with 2 parameters
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {

                return true;
            }
            else
            {

                return false;
            }
        }

        //create operator overload method for '!=' with 2 parameters
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {

                return true;
            }
            else
            {

                return false;
            }
        }

    }
}
