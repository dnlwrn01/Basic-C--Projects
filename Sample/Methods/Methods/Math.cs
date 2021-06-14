using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Math
    {
        //define * method passing userNum
        public int MultiplyNum(int userNum)
        {
            int product = userNum * 2;
            return product;
        }

        //define / method passing userNum
        public int DivideNum(int userNum)
        {
            int quoitent = userNum / 2;
            return quoitent;
        }

        //define + method passing userNum
        public int AddNum(int userNum)
        {
            int sum = userNum + 2;
            return sum;
        }

        //define - method passing userNum
        public int SubtractNum(int userNum)
        {
            int difference = userNum - 2;
            return difference;
        }
    }
}
