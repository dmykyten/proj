using proj.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj.Expressions
{
    public class Expression1:AbstractExpression
    {
        int first;
        int second;

        public Expression1(int aa, int bb, IOutput outt):base(outt)
        {
            first = aa;
            second = bb;
        }
        public Expression1(IOutput outt) : base(outt)
        {
            first = 10;
            second = 20;
        }
        public void Evaluate()
        {
            int c = first * second;
            //Console.WriteLine(c);
            output.WriteLine(c.ToString());
        }
    }
}
