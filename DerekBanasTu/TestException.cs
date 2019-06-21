using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class TestException : Exception
    {
        public override string ToString()
        {
            return "This is MyException!!";
        }
    }
}
