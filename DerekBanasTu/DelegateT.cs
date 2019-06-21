using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class DelegateT//pass function as parameter to other function
    {
        public delegate void MyDelegate(double num1, double num2);
        

        public void sum(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public void mul(double num1, double num2)
        {
            Console.WriteLine(num1 * num2);
        }
        //Delegate parameter
        public static void sendFunction(MyDelegate delegateFunc, double v1, double v2)
        {
            delegateFunc(v1,v2);
        }

        //Generic Zone
            public delegate void MyGenericDelegate<T1>(T1 param1, T1 param2);
            public void concate(string num1, string num2)
            {
                Console.WriteLine(num1 + num2);
            }
            //on sendGenericFunction<T1> || T1 is declare on sendGenericFunction<double>(sum, 5,3); sendGenericFunction<string>(concate, "5", "3");
            //on MyGenericDelegate<T1> delegateFunc, T1 v1, T1 v2 || T1 is declare on public delegate void MyGenericDelegate<T1>
            public static void sendGenericFunction<T1>(MyGenericDelegate<T1> delegateFunc, T1 v1, T1 v2)
            {
                delegateFunc(v1, v2);
            }
            public static void sendGenericFunction2<T1,T2>(MyGenericDelegate<T1> delegateFunc1, T1 v1_1, T1 v1_2, MyGenericDelegate<T2> delegateFunc2, T2 v2_1, T2 v2_2)
            {
                delegateFunc1(v1_1, v1_2);
                delegateFunc2(v2_1, v2_2);
            }
        //End Generic Zone
        public void callDelegateTest(double a1,double a2 ,double m1,double m2)
        {
            Console.WriteLine("=============== Delegate ================");
            MyDelegate MD = sum;
            MD.Invoke(a1, a2);
            MD = mul;
            MD.Invoke(m1, m2);

            Console.WriteLine("=============== Delegate Anonymous  ================");
            MyDelegate MDA = delegate (double num1,double num2)
            {
                Console.WriteLine(num1 + num2);
            };
            MDA(a1, a2);

            //Delegate parameter
            Console.WriteLine("=============== Delegate with parameter ================");
            sendFunction(sum, a1, a2);
            sendFunction(mul, m1, m2);

            Console.WriteLine("=============== Multicast delegate ================");
            MD += sum;
            MD.Invoke(m1, m2);

            Console.WriteLine("=============== Generic Delegate ================");
            MyGenericDelegate<double> MGD = sum;
            MGD.Invoke(5, 3);
            MyGenericDelegate<string> MGD2 = concate;
            MGD2.Invoke("5", "3");
            Console.WriteLine("=============== Generic Delegate with parameter ================");
            sendGenericFunction<double>(sum, 5,3);
            sendGenericFunction<string>(concate, "5", "3");
            Console.WriteLine("=============== Generic Delegate with parameter ver2 ================");
            sendGenericFunction2<double, string>(sum, 5, 3, concate, "5", "3");
     






        }
    }
}
