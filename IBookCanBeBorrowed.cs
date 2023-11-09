using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuellt_Boksystem
{
    public interface IBookCanBeBorrowed
    {
        public void LendABook();
        public void ReturnABook();
    }
}
