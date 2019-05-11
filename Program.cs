using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{

    class Program
    {
        static void Main(string[] args)
        {

            var exp = new Expression1(new Output());
            exp.Evaluate();
            var exp2 = new Expression1(30,40,new Output());
            exp2.Evaluate();
            var exp3 = new BubbleSort(new Output());
            exp3.Evaluate();
            Console.ReadKey();
        }
    }
}
