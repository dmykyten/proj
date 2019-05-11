using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    public class ConsoleOutput:IOutput
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
        public void Write(string text)
        {
            Console.Write(text);
        }
    }
}
