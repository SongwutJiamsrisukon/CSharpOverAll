using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class Program
    {
        public static void inOutPut(){
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
        public static void maxNum(){
            int maxInt = int.MaxValue;
            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("maxLong = " + long.MaxValue);
            Console.WriteLine("maxDecimal = " + decimal.MaxValue);
            Console.WriteLine("maxFloat = " + float.MaxValue);
            Console.WriteLine("maxDouble = " + double.MaxValue);

        }
        public static void checkType(){
            int testInt = 10;long testLong = 10;
            string testString = "testString";
            var testVar1 = 10;
            var testVar2 = "testString";

            //{0} set different data on {0}
            Console.WriteLine("type name is {0}, {1}", testInt.GetTypeCode(), testLong.GetTypeCode()); //when had many value like {0}, {1}, {2} it is easy to use.
            Console.WriteLine("type name is {0}", testString.GetTypeCode());
            Console.WriteLine("type name is {0}", testVar1.GetTypeCode());
            Console.WriteLine("type name is {0}", testVar2.GetTypeCode());
            Console.WriteLine("type name is " + testInt.GetTypeCode() + ", " + testLong.GetTypeCode()); //when had many value it confuse on + many times.
            Console.WriteLine("type name is " + testString.GetTypeCode());
            Console.WriteLine("type name is " + testVar1.GetTypeCode());
            Console.WriteLine("type name is " + testVar2.GetTypeCode());
        }
        public static void casting(){
            double pi = 3.74;
            int intPi = (int)pi;
            Console.WriteLine(intPi);

            pi = 4.74;
            Console.WriteLine((int)pi);
        }
        public static void math(){

            double num1 = 10.3;
            double num2 = 15;
            Console.WriteLine("num1 = " + num1 + ", num2 = " + num2);
            Console.WriteLine("Math.Abs(num1) = " + Math.Abs(num1));
            Console.WriteLine("Math.Ceiling(num1) = " + Math.Ceiling(num1));
            Console.WriteLine("Math.Floor(num1) = " + Math.Floor(num1));
            Console.WriteLine("Math.Max(num1,num2) = " + Math.Max(num1, num2));
            Console.WriteLine("Math.Min(num1,num2) = " + Math.Min(num1, num2));
            Console.WriteLine("Math.Pow(num1,2) = " + Math.Pow(num1,2));
            Console.WriteLine("Math.Round(num1) = " + Math.Round(num1));
            Console.WriteLine("Math.Sqrt(num1) = " + Math.Sqrt(num1));
        }
        public static void randomT(){
            Random rand = new Random();
            Console.WriteLine("Random Number between 5 to 10: " + rand.Next(5, 10));
        }
        public static void shortFunc() {
            int age = 17;
            int age2 = age > 16 ? 160 : age;
            Console.WriteLine("age > 16 ? 160 : age | ans = " + age2);
        }
        public static void stringFunc()
        {
            string name = "Nagato";
            Console.WriteLine(name == "Nagato");
            Console.WriteLine(name.Equals("Nagato"));
            foreach (char c in name) { Console.Write(c); }
            Console.WriteLine();
            string SampleString = " \"Test\t\'GG\\WP\"";
            Console.WriteLine(SampleString);
            SampleString = "Test GGWP";
            Console.WriteLine("IsNullOrEmpty(\"Test GGWP\"): " + String.IsNullOrEmpty(SampleString));
            Console.WriteLine("IsNullOrWhiteSpace(\"Test GGWP\"): " + String.IsNullOrWhiteSpace(SampleString));
            Console.WriteLine("(\"Test GGWP\").Replace(\"Test \",\"Mace\")): " + SampleString.Replace("Test ", "Mace"));
            Console.WriteLine("(\"Test GGWP\").StartsWith(\"Tes\"): " + SampleString.StartsWith("Tes"));
            Console.WriteLine("(\"Test GGWP\").EndsWith(\"GWP\"): " + SampleString.EndsWith("GWP"));
            Console.WriteLine("(\"Test GGWP\").Length: " + SampleString.Length);
            Console.WriteLine("(\"Test GGWP\").IndexOf(\"GGWP\"): " + SampleString.IndexOf("GGWP"));
            Console.WriteLine("(\"Test GGWP\").IndexOf(\"WPGG\"): " + SampleString.IndexOf("WPGG"));
            Console.WriteLine("(\"Test GGWP\").Substring(2,4): " + SampleString.Substring(2,4));

            Console.WriteLine("IsNullOrEmpty(null): " + String.IsNullOrEmpty(null));
            Console.WriteLine("IsNullOrEmpty(\"\"): " + String.IsNullOrEmpty(""));
            Console.WriteLine("IsNullOrWhiteSpace(\"    \"): " + String.IsNullOrWhiteSpace("     "));
        }
        public static void stringFormatFunc(){
            Console.WriteLine(String.Format("{0:c}", 1.56));//currency $
            Console.WriteLine(String.Format("{0:00.00}", 15.567));//xx.xx
            Console.WriteLine(String.Format("{0:#.00}", 0.562));//blank.xx
            Console.WriteLine(String.Format("{0:0,0}", 100000));
            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .562, 1000);
            Console.WriteLine(fmtStr);
        }
        public static void arrayT() {
            int[] randArray1 = new int[5];//use dynamic array with List<int>
            int[] randArray2 = { 0,8,7,4,1 };
            string[] names = { "ccc","xxx","yyy","zzz"};
            Console.WriteLine("String.Join(\", \",names): " + String.Join(", ", names));//not working on 2 dimesion array
            Console.WriteLine("String.Join(\", \",randArray2): " + String.Join(", ", randArray2));
            Console.WriteLine("Array.IndexOf(names, \"yyy\"): " + Array.IndexOf(names, "yyy"));
            Console.WriteLine("Array.IndexOf(randArray2, 8): " + Array.IndexOf(randArray2, 8));
            Console.WriteLine();
            Console.WriteLine("Multi Dimensional Array");
            int[,] mulInt0 = new int[2, 3];
            int[,] mulInt1 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };// int 2,3

            foreach (int t in mulInt1){
                Console.Write(t); Console.Write(' ');
            }
            Console.WriteLine();
            for (int i = 0; i < mulInt1.GetLength(0); i++)
            {
                for (int j = 0; j < mulInt1.GetLength(1); j++)
                {
                    Console.WriteLine("{0} | {1}: {2}", i, j, mulInt1[i, j]);
                }
            }
            Console.WriteLine();
        }
        public static void arrayListT()
        {
            List<int> numList = new List<int>();
            Console.WriteLine("List<int> numList = new List<int>(); {initial List}");
            numList.Add(5); numList.Add(15); numList.Add(25);
            Console.WriteLine(String.Join(", ", numList) + " {numList.Add(5); numList.Add(15); numList.Add(25);}");

            int[] numArray = { 1, 2, 3, 4 };
            numList.AddRange(numArray);
            Console.WriteLine(String.Join(", ", numList) + " {numList.AddRange(numArray)}");

            List<int> numList2 = new List<int>(numList);//copy
            Console.WriteLine("List<int> numList2 = new List<int>(numList); {Copy List}");
            numList.Insert(1,9999);
            
            Console.WriteLine(String.Join(", ", numList) + " {numList.Insert(1, 9999)}");
            Console.WriteLine(String.Join(", ", numList2) + " {numList2}");

            numList.Remove(9999);
            Console.WriteLine(String.Join(", ", numList) + " {numList.Remove(9999)}");

            numList.RemoveAt(2);
            Console.WriteLine(String.Join(", ", numList) + " {numList.RemoveAt(2)}");

            //find index from value
            Console.WriteLine("numList.IndexOf(15): " + numList.IndexOf(15));
            Console.WriteLine("numList.Contains(15): " + numList.Contains(15));
            Console.WriteLine("numList.Contains(9999): " + numList.Contains(9999));
            numList.Sort();
            Console.WriteLine(String.Join(", ", numList) + " {after do numList.Sort();}");


            Console.WriteLine("--------------------------------------");
            List<string> srtList = new List<string>(new string[] { "Tom", "Paul" });

            string temp;
            for (int i =0;i< srtList.Count; i++)
            {
                temp = (i+1 == srtList.Count) ? (srtList[i]) : (srtList[i] + ", ");
                Console.Write(temp);
            }Console.WriteLine();
            
            Console.WriteLine("srtList.Contains(\"tom\"): " + srtList.Contains("tom"));
            Console.WriteLine("srtList.Contains(\"Tom\"): " + srtList.Contains("Tom"));
            Console.WriteLine("srtList.Contains(\"tom\",StringComparer.OrdinalIgnoreCase): " + srtList.Contains("tom",StringComparer.OrdinalIgnoreCase));

            srtList.Sort();
            Console.WriteLine(String.Join(", ", srtList) + " {after do srtList.Sort();}");
        }
        public static void overloadFunc()
        {
            Console.WriteLine(getSum(1, 2));
            Console.WriteLine(getSum(2, 1.5));
            Console.WriteLine(getSum(num2: 2, num1: 1.5));
        }
        public static int getSum(int num1, int num2)//call from overloadFunc()
        {
            return (num1 * 10) + num2;
        }
        public static double getSum(double num1, double num2)//call from overloadFunc()
        {
            return (num1 * 10) + num2;
        }
        public static void exceptionHandingT()
        {
            try
            {
                Console.Write("Try to divide 10 with your value(Try 0 to divide by zero): ");
                int num = int.Parse(Console.ReadLine());

                /* ThisYou can throw like this but it is not nesscessary because when (10 / num) the system know this is DivideByZeroException!
                if (num == 0){
                    throw new DivideByZeroException();
                }
                */

                Console.WriteLine("10/{0} = {1}", num, (10 / num));
            }
            catch (DivideByZeroException ex)
            {//DivideByZeroException
                Console.WriteLine("can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)//All exception handle, do this scope if not in DivideByZeroException scope
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

        }
        public static void creatingExceptionAndUseByThrow()
        {
            try
            {
                Console.Write("Try -1 to catch by MyException: ");
                int num = int.Parse(Console.ReadLine());
                if (num == -1)
                {
                    throw new TestException();
                    //throwHere();//สามารถ throw ในฟังก์ชันที่ประกาศไว้ภายนอกได้ แต่ตัว call ฟังก์ชันต้องอยู่ใน try scope
                }
                Console.WriteLine("10/{0} = {1}", num, (10 / num));
            }
            catch (TestException testEx)//create class TestException extend Exception//declare before catch (Exception ex)
            {
                Console.WriteLine(testEx.ToString());//
            }
            catch (Exception ex)//All exception handle, do this scope if not in TestException scope //auto use devideByZeroException
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

        }
        public static void throwHere()
        {
            throw new TestException();//สามารถ throw ในฟังก์ชันที่ประกาศไว้ภายนอกได้ แต่ตัว call ฟังก์ชันต้องอยู่ใน try scope
        }
        public static void classWithStaticAndNonStaticFuncAndVar()
        {
            Animal tiger = new Animal(15, 10, "Tiger", "Hwoo");
            Console.WriteLine(tiger.toString());

            Animal notAny = new Animal();
            Console.WriteLine("{0} says {1}", notAny.name, notAny.sound);

            Animal objectInitializer = new Animal
            {
                height = 1.5,
                weight = 1.5,
                name = "object",
                sound = "initializer"
            };
            Console.WriteLine(objectInitializer.toString());

            Console.WriteLine("Number of Animals = " + Animal.getNumOfAnimals());//call static function use class name
        }
        public static void subClassInheritance()
        {
            List<Animal> animals = new List<Animal>();
            Animal tiger = new Animal(15, 10, "Tiger", "Hwoo");
            Console.WriteLine(tiger.toString());
            Console.WriteLine("Number of Animals = " + Animal.getNumOfAnimals());//call static function use class name

            Animal husky = new Dog(12, 10, "Husky", "Hong", "Meat");//polymorphism deals with virtual(or abstract) and overring
            Console.WriteLine(husky.toString());
            Console.WriteLine("Number of Animals = " + Animal.getNumOfAnimals() + " | " + Dog.getNumOfSubAnimals());//call static function use class name

            Animal americanShort = new Cat(12, 10, "AmericanShort", "Meow", "Chicken");//polymorphism deals with virtual(or abstract) and overring
            Console.WriteLine(americanShort.toString());
            //Cat.getNumOfAnimals() call Animal.getNumOfAnimals() 
            Console.WriteLine("Number of Animals = " + Cat.getNumOfAnimals() + " | " + Cat.getNumOfSubAnimals());//call static function use class name

            Animal husky2 = new Dog(12, 10, "Husky2", "Hong", "Meat");//polymorphism deals with virtual(or abstract) and overring
            Console.WriteLine(husky2.toString());
            //Dog.getNumOfAnimals() call Animal.getNumOfAnimals() 
            Console.WriteLine("Number of Animals = " + Dog.getNumOfAnimals() + " | " + Dog.getNumOfSubAnimals());//call static function use class name

            animals.Add(tiger);
            animals.Add(husky);
            animals.Add(americanShort);
            animals.Add(husky2);
            Console.WriteLine("=======================================");
            for (int i = 0 ; i < animals.Count; i++)
            {
                Console.WriteLine(animals[i].toString());
            }

        }
        public static void subClassAndClassInterface()
        {
            Cat2I c2 = new Cat2I();
            Console.WriteLine(c2.toString()); //Cat2I is inherite from Cat
            Console.WriteLine("----------Cat Interface---------");
            c2.atk();
            c2.duty();

            Dog2I d2 = new Dog2I();
            //Console.WriteLine(d2.toString()); Can't use because Dog2I is not inherite from Dog
            Console.WriteLine("----------Dog Interface---------");
            d2.atk();
            d2.duty();

        }
        public static void subClassAbstract()
        {
            Cat2Abs c2 = new Cat2Abs();
            Console.WriteLine("----------Cat Abstract---------");
            Console.WriteLine(c2.toString());
            c2.atk();
            c2.duty();
            c2.canUseFuncInAbstractClass();

            Dog2Abs d2 = new Dog2Abs();
            Console.WriteLine("----------Dog Abstract---------");
            Console.WriteLine(d2.toString()); 
            d2.atk();
            d2.duty();
            d2.canUseFuncInAbstractClass();
        }
        public static void operatorOverloading()
        {
            HeroStat a = new HeroStat(5,10);
            HeroStat b = new HeroStat(10, 15);

            //operatorOverloading()
            HeroStat c = a + b;//public static HeroStat operator+(HeroStat a, HeroStat b)

            a.getStat();
            b.getStat();
            c.getStat();
        }
        public static void genericClass()
        {
            GenericClassSample<string, double> g1 = new GenericClassSample<string, double>("Diamond",3200.00);
            GenericClassSample<int, double> g2 = new GenericClassSample<int, double>(99, 2500);
            GenericClassSample<string, string> g3 = new GenericClassSample<string, string>("DiamondA", "DDD");
            g1.print();
            g2.print();
            g3.print();

            Console.WriteLine(g1.outputT2WithInpuutT1(g1.t1));
            Console.WriteLine(g1.outputT2WithInpuutT1("Diamond"));
            Console.WriteLine(g1.outputT2WithInpuutT1("NotEquals"));
            Console.WriteLine(g1.outputT2WithInpuutT1(55555));
            Console.WriteLine("====================================================");
            Console.WriteLine(g2.outputT2WithInpuutT1(g2.t1));
            Console.WriteLine("====================================================");
            Console.WriteLine("Set g3.t1 = Diamond and compare g3.t1 with g1.t1 on func outputT2WithInpuutT1");
            g3.t1 = "Diamond";
            Console.WriteLine(g3.outputT2WithInpuutT1(g1.t1));

        }
        public static void genericClassInheritance()
        {
            Console.WriteLine("============= Parent Generic ============");
            MyGenericSuperClass<int> gsc0_1 = new MyGenericSuperClass<int>(7);
            Console.WriteLine(gsc0_1.print());

            Console.WriteLine("============= Child Generic <Ts,T> ============");
            MyGenericSubClass1<int, int> gsc1_1 = new MyGenericSubClass1<int, int>(5,7);
            Console.WriteLine(gsc1_1.print());

            MyGenericSubClass1<int, double> gsc1_2 = new MyGenericSubClass1<int, double>(5, 77.7);
            Console.WriteLine(gsc1_2.print());

            MyGenericSubClass1<int, string> gsc1_3 = new MyGenericSubClass1<int, string>(5, "Ha");
            Console.WriteLine(gsc1_3.print());

            Console.WriteLine("============= Child Generic <default int ,Set T to string> ============");
            MyGenericSubClass2 gsc2_1 = new MyGenericSubClass2(5, "HaHa");
            Console.WriteLine(gsc2_1.print());

        }
        public static void lamdhaExpressionSample()
        {
            char num = '7';//'z'
            if ("0123456789.".Any(c => num == c)) // (num=='1' || num=='2' ||....... || num=='.')
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }

        static void Main(string[] args)
        { //static method can't access non static variable and non static method(but can acess enum) //non static method can access static mehod and static value;
          //inOutPut();
          //maxNum();
          //checkType();
          //casting();
          //math();
          //randomT();
          //shortFunc();
          //stringFunc();
          //stringFormatFunc();
          //arrayT();
          //arrayListT();
          //overloadFunc();
          //exceptionHandingT();
          //creatingExceptionAndUseByThrow();//add1 TestException.cs
          //---ดู OOPภาพประกอบ เพื่อเพิ่มความเข้าใจ
          //classWithStaticAndNonStaticFuncAndVar();//add1class Animal.cs
          //subClassInheritance();//add2class Cat.cs, Dog.cs
          //subClassAndClassInterface();//add4class SubAnimalInterface, SubAnimalInterface2, Cat2I.cs, Dog2I.cs 
          //---abstract class จะเป็นการทำ polymorph อัตโนมัติให้กับ function ที่เป็น abstract โดยไม่ต้องพิมพ์ virtual
          //subClassAbstract();//add4class /SubCatAbstract.cs, SubDogAbstract.cs, Cat2Abs.cs, Dog2Abs.cs
          //---EndOOP
          //operatorOverloading();//add1class HeroStat
          //genericClass();//add1class GenericClassSample.cs
          //genericClassInheritance();//add2(3)class MyGenericSuperClass.cs, MyGenericSubClass.cs(had 2 class inside MyGenericSubClass1,MyGenericSubClass2)
          //EnumStruct.testStaticEnum(); //EnumStruct ES = new EnumStruct();   ES.testEnum();
          //EnumStruct.testStruct();
          //DelegateT DT = new DelegateT(); DT.callDelegateTest(2,5,3,10); //add1class DelegateT
            //lamdhaExpressionSample();
        }
    }
}
