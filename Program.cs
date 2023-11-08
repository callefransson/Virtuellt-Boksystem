using System;
using System.Net.Http.Headers;

namespace Virtuellt_Boksystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Media> mediaItems = new List<Media>();
            {
                new Book("Hur github funkar!", "Malin", 1);
                new Ebook("Hur github inte funkar!", "Malin",2,50,"www.github.com");
            }

            foreach (var item in mediaItems)
            {
                item.ShowInfo();
            }
        }
    }
}