using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        //own getter setter (You can specify value example name value doesn't contain number and write to show why)
        public string name;
        public string Name
        {
            get { return name; }
            set {
                    if (value != "dark") { //value is set defalut value to each variable type
                        name = value;
                    }
                    else{
                        name = "No Name";
                    }
                }
        }

        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.Name = "dark";
            this.sound = "No Sound";
            numOfAnimals++;//non static call static variable
        }

        public Animal(double height, double weight, string name, string sound){
            this.height = height;
            this.weight = weight;
            this.Name = name;
            this.sound = sound;
            addingNumOfAnimals();//non static call static method
        }

        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }
        public static void addingNumOfAnimals()
        {
            numOfAnimals++;
        }

        public virtual string toString()//virtual can use polymorphism when overriding
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height, weight, sound);
        }

    }
}
