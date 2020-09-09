using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture15
{
    public class ClassSum
    {
        int a = 10;
        int b = 15;
        int sum;
        ////Sum(a, b, out sum);
        //Console.Writeline(sum);
        public void Sum(int a, int b, out int sum)
        {
            sum = a + b;
        }
    }


}
