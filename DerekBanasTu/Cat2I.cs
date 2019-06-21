using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class Cat2I : Cat, SubAnimalInterface, SubAnimalInterface2// use : first and then use ,
    {
        //public Cat2I() : base() { }    //no need to use because it auto use from Cat() constructor
        public void atk()
        {
            Console.WriteLine("Scratch");
        }

        public void duty()
        {
            Console.WriteLine("Kill Human");
        }
    }
}
