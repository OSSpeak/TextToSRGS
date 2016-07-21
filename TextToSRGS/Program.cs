using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSRGS
{
    class Program
    {
        static void Main(string[] args)
        {
            Api.TextToSRGSXML("foo bar");
            Console.ReadLine();
        }
    }
}
