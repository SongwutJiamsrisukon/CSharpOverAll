using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    abstract class SubDogAbstract : Dog, SubAnimalInterface2
    {
        public abstract void atk();//abstract is auto polymorphing like virtual

        public void canUseFuncInAbstractClass()
        {
            Console.WriteLine("canUseFuncInAbstractClass");
        }

        public void duty()
        {
            Console.WriteLine("Protect Human");
        }
    }
}
