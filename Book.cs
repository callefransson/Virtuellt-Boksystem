using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuellt_Boksystem
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("hejsan");
        }
    }
}
