using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj.Output
{
    public interface IOutput
    {
        void WriteLine(string text);
        void Write(string text);
    }
}
