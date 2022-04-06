using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    class JsonWriter : IFormatWriter
    {
        public void WriteHeading1(string caption)
        {
            Console.WriteLine($"document.write(\"<h1>{caption}</h1>\")");
            Console.WriteLine(new string('=', caption.Length));
        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine($"document.write(\"<h2>{caption}</h2>\")");
            Console.WriteLine(new string('-', caption.Length));
        }

        public void WriteParagraph(string text)
        {
            string s = "{" + "\"text\"" + ":" + "\"" + text + "\"" + "}";
            Console.WriteLine(s);
        }
    }
}