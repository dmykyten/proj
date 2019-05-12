using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj.Output
{
    class FileOutput : IOutput
    {
        string filePath;
        public FileOutput(string path)
        {
            filePath = path;
        }
        public void Write(string text)
        {
            File.AppendAllText(filePath, text);
        }

        public void WriteLine(string text)
        {
            File.AppendAllText(filePath, text + "\r\n");
        }

        public void DeleteFile()
        {
            File.Delete(filePath);
        }
    }
}
