using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    class FileOutput : IOutput
    {
        string FilePath;
        public FileOutput(string path)
        {
            FilePath = path;
        }
        public void Write(string text)
        {
            File.AppendAllText(FilePath, text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(FilePath, text + "\r\n");
        }
    }
}
