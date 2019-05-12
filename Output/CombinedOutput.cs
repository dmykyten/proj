using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj.Output
{
    public class CombinedOutput : IOutput
    {
        IOutput[] outputs;
        public CombinedOutput(IOutput first,params IOutput[] rest) {
            outputs = new IOutput[rest.Length + 1];
            outputs[0] = first;
            for(int i = 1;i != rest.Length + 1; i++)
            {
                outputs[i] = rest[i - 1];
            }
        }
        public void Write(string text)
        {
            for(int i = 0; i != outputs.Length; i++)
            {
                outputs[i].Write(text);
            }
        }

        public void WriteLine(string text)
        {
            for(int i = 0; i != outputs.Length; i++)
            {
                outputs[i].WriteLine(text);
            }
        }
    }
}
