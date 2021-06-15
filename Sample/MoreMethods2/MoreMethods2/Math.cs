using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods2
{
    class Math
    {
        //method with 2 parameters (1 optional)
        public int AddNum(int one, int two = 0)
        {
            int result = one + two;
            return result;
        }
    }
}
