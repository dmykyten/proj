using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    public class Expression1
    {
        int first;
        int second;
        public Expression1(int aa,int bb)
        {
            first = aa;
            second = bb;
        }
        public Expression1()
        {
            first = 10;
            second = 20;
        }
        public void Evaluate()
        {
            int c = first * second;
            Console.WriteLine(c);
        }
    }
}
