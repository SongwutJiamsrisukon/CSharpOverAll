using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class Dog:Animal
    {
        public string favFood { get; set; }

        public Dog() : base()//initial Animal()
        {
            this.favFood = "No Favorite Food";
        }

        public Dog(double height, double weight, string name, string sound, string favFood) : base(height, weight, name, sound)//initial Animal(double height, double weight, string name, string sound)
        {
            this.favFood = favFood;
            numOfSubAnimals++;
        }

        

        public override string toString()//overriding
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}", name, height, weight, sound, favFood);
        }

        static int numOfSubAnimals = 0;
        public static string getNumOfSubAnimals()
        {
            return "Number of Dogs: " + numOfSubAnimals;
        }


    }
}
