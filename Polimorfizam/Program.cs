using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IFormatWriter writer = null;

            Console.WriteLine("Select format of the output: (P)lain or (H)tml");
            string response = Console.ReadLine();
            switch (response.ToLower()[0])
            {
                case 'p':
                    writer = new PlainTextTextWriter();
                    break;
                case 'h':
                    writer = new HtmlWriter();
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }

            StoryTeller st = new StoryTeller(writer);
            st.WriteHeading1("Priče iz davnine");
            st.WriteHeading2("Šuma Striborova");
            st.WriteParagraph("Zašao neki momak u šumu Striborovu, a nije znao da je ono šuma začarana i da se u njoj svakojaka čuda zbivaju.");

            Console.ReadKey(false);
        }
    }
}
