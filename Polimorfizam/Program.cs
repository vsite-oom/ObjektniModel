using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    /// <summary>
    /// Example
    /// </summary>
    class Program
    {
        /// <summary>
        /// desc
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IFormatWriter writer = null;

            Console.WriteLine("Select format of the output: (P)lain or (H)tml");
            string response = Console.ReadLine();
            switch (response.ToLower()[0])
            {
                case 'p':
                    writer = new PlainTextWriter();
                    break;
                case 'h':
                    writer = new HtmlWriter();
                    break;
                default:
                    Console.WriteLine("invalid entry");
                    break;
                
            }

            StoryTeller st = new StoryTeller(new PlainTextWriter());
            st.WriteHeading1("Priče iz davnine");
            st.WriteHeading2("Šuma Striborova");
            st.WriteParagraph("Zašao neki momak u šumu Striborovu, a nije znao da je ono šuma začarana i da se u njoj svakojaka čuda zbivaju.");

            Console.ReadKey(false);
        }
    }
}
