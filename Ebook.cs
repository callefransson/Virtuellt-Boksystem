using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Virtuellt_Boksystem
{
    public class Ebook : Book
    {
        public int FileSize { get; set; }
        public string DownloadUrl { get; set; }

        public Ebook(string title, string author, string isbn, int filesize, string downloadurl) 
        {
            FileSize = filesize;
            DownloadUrl = downloadurl;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Title} {Author} {ISBN} {FileSize} {DownloadUrl}");
            base.PrintInfo();
        }

    }
}
