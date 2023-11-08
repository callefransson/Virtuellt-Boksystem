using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuellt_Boksystem
{
    public class IBookCanBeBorrowed
    {
        public void LendABook()
        {
            Console.WriteLine("you have lenmd a book");
        }

        public void ReturnAbook()
        {
            Console.WriteLine("you have return a book");
        }
    }
}
