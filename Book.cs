using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuellt_Boksystem
{
    interface IBookCanBeBorrowed
    {
        void LendABook();
        void ReturnABook();
    }
    internal class Book : Media, IBookCanBeBorrowed
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

        public void LendABook()
        {
            Console.WriteLine("you have lend a book");
        }
        public void ReturnABook()
        {
            Console.WriteLine("you have returned a book");
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Name of the book: {0} The author: {1} ISBN: {2}",Title,Author,ISBN);
        }

        public override void ShowInfo()
        {
            PrintInfo();
        }

        public override void Play()
        {
            
        }       
    }
}
