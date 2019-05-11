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
        IOutput output;

        public Expression1(int aa,int bb,IOutput outt)
        {
            first = aa;
            second = bb;
            output = outt;
        }
        public Expression1(IOutput outt)
        {
            first = 10;
            second = 20;
            output = outt;
        }
        public void Evaluate()
        {
            int c = first * second;
            //Console.WriteLine(c);
            output.WriteLine(c.ToString());
        }
    }
}
