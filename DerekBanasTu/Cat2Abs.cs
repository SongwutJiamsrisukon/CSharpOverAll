using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class Cat2Abs : SubCatAbstract, SubAnimalInterface2
    {
        public override void atk()
        {
            Console.WriteLine("Scratch");
        }

        public void duty()
        {
            Console.WriteLine("Kill Human");
        }
    }
}


