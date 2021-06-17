using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //employee class takes parameter type
    public class Employee <T>
    {
        //add properties
        public List<T> things { get; set; }
    }
}
