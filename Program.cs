using proj.Expressions;
using proj.Output;
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
            var exp2 = new Expression1(30, 40, new ConsoleOutput());
            exp2.Evaluate();
            //var exp3 = new BubbleSort(new ConsoleOutput());
            //var exp3 = new BubbleSort(new FileOutput("output.txt"));
            var exp3 = new BubbleSort(
                new CombinedOutput(
                    new FileOutput("output.txt"),
                    new FileOutput("output2.txt"),
                    new ConsoleOutput()
                )
            );
            exp3.Evaluate();
            Console.ReadKey();
        }
    }
}
