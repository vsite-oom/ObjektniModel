using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    class Jsonwriter : IFormatWriter
    {
        public void WriteParagraph(string text)
        {
            Console.WriteLine($"{{\"paragraph\":\"{text}\"}}");
        }

        public void WriteHeading1(string caption)
        {
            Console.WriteLine($"{{\"heading1\":\"{caption}\"}}");
            Console.WriteLine(new string('=', caption.Length * 2));
        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine($"{{\"heading2\":\"{caption}\"}}");
            Console.WriteLine(new string('-', caption.Length * 2));
        }
    }
}
