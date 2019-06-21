using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class HeroStat
    {
        public int str;
        public int vit;


        public HeroStat(int str, int vit)
        {
            this.str = str;
            this.vit = vit;
        }

        public void getStat()
        {
            Console.WriteLine("Str: {0},Vit: {1} | Power: {2}", str, vit, str + vit);
        }

        public static HeroStat operator+(HeroStat a, HeroStat b)
        {
            return new HeroStat(a.str + b.str, a.vit + b.vit);
        }
    }
}
