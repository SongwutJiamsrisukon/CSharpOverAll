using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class Dog2I : SubAnimalInterface, SubAnimalInterface2 // use : first and then use , (Dog2I not inherite from dog)
    {
        public void atk()
        {
            Console.WriteLine("Bite");
        }

        public void duty()
        {
            Console.WriteLine("Protect Human");
        }
    }
}
