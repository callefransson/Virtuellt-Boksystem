using System;
using System.Net.Http.Headers;

namespace Virtuellt_Boksystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> mediaItems = new List<Book>();

            mediaItems.Add(new Book("Hur github funkar!", "Malin", 1));
            mediaItems.Add(new Ebook("Hur github inte funkar!", "Malin", 2, 50, "www.github.com"));

            foreach (var item in mediaItems)
            {
                item.PrintInfo();
            }
        }
    }
}