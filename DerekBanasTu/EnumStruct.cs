using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class EnumStruct
    {
        public enum Score
        {
            Bad, Normal, Good
        }

        public struct CharacterStat
        {
            public string name;
            public int level;
            public void createTestStruct(string name, int level)
            {
                this.name = name;
                this.level = level;
            }
      
        }
        public static void testStaticEnum()
        {
            Score s = Score.Good;
            if (Score.Good == s)
                Console.WriteLine("ScoreGood = " + s);
            else
                Console.WriteLine("Not Equal");
        }
        public void testEnum()
        {
            Score s = Score.Good;
            if (Score.Good == s)
                Console.WriteLine("ScoreGood = " + s);
            else
                Console.WriteLine("Not Equal");
        }
        public static void testStruct()
        {
            CharacterStat CS = new CharacterStat();//example like class you can use class instead
            CS.createTestStruct("SamuraiYaiba", 99);
            Console.WriteLine("Character name is: {0} | Level is: {1}",CS.name,CS.level);

        }


    }
}
