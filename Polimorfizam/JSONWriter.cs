using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    class JSONWriter : IFormatWriter
    {
        public void WriteParagraph(string text)
        {
            string json = $"{{\"paragraph\":\"{text}\"}}";
            Console.WriteLine(json);
        }

        public void WriteHeading1(string caption)
        {
            string json = $"{{\"heading1\":\"{caption}\"}}";
            Console.WriteLine(json);
            Console.WriteLine(new string('=', caption.Length));
        }

        public void WriteHeading2(string caption)
        {
            string json = $"{{\"heading2\":\"{caption}\"}}";
            Console.WriteLine(json);
            Console.WriteLine(new string('-', caption.Length));
        }
    }
}
