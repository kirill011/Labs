using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gaz.Lab3._1
{
    internal class TextFileOperations
    {
        public string ReadTextFileContents(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        public void WriteTextFileContents(string fileName, string text)
        {
            File.WriteAllText(fileName, text);
        }
    }
}
