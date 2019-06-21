using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    abstract class SubCatAbstract : Cat
    {
        public abstract void atk();//abstract is auto polymorphing like virtual

        public void canUseFuncInAbstractClass()
        {
            Console.WriteLine("canUseFuncInAbstractClass");
        }
    }
}
