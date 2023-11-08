using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuellt_Boksystem
{
    public interface IBookCanBeBorrowed
    {
        public void LendABook()
        {
            Console.WriteLine("you have lend a book");
        }

        public void ReturnAbook()
        {
            Console.WriteLine("you have returned a book");
        }
    }
}
