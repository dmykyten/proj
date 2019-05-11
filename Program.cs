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

            var exp = new Expression1(new FileOutput("output.txt"));
            exp.Evaluate();
            var exp2 = new Expression1(30,40,new ConsoleOutput());
            exp2.Evaluate();
            //var exp3 = new BubbleSort(new ConsoleOutput());
            var exp3 = new BubbleSort(new FileOutput("output.txt"));
            exp3.Evaluate();
            Console.ReadKey();
        }
    }
}
