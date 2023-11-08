using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuellt_Boksystem
{
    internal class Book :IBookCanBeBorrowed
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }

        public Book(string title, string author, int iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("hejsan");
        }
    }
}
