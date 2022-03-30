using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    class HtmlWriter : IFormatWriter
    {
        public void WriteParagraph(string text)
        {
            Console.WriteLine($"<p>{text}</p>");
        }

        public void WriteHeading1(string caption)
        {
            Console.WriteLine($"<h1>{caption}</h1>");
            Console.WriteLine(new string('=', caption.Length));
        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine($"<h2>{caption}</h2>");
            Console.WriteLine(new string('-', caption.Length));
        }
    }
}
