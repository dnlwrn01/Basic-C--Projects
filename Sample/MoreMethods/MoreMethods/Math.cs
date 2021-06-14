using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    class Math
    {
        //int method for addition
        public int AddNum(int userNum)
        {
            int result = userNum + 100;
            return result;
        }

        //decimal method for addition
        public int AddNum(decimal userDecimalNum)
        {
            decimal temp = userDecimalNum + 1200;
            int result = Convert.ToInt32(temp);
            return result;
        }

        //string method for addition
        public int AddNum(string userStringNum)
        {
            int temp = int.Parse(userStringNum);
            int result = temp + 5;
            return result;
        }
    }
}
