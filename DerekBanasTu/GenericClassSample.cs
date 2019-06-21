using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class GenericClassSample<T1,T2>
    {
        public T1 t1 { get; set; }
        public T2 t2 { get; set; }

        public GenericClassSample(T1 t1,T2 t2)
        {
            this.t1 = t1;
            this.t2 = t2;
        }

        public void print()
        {
            Console.WriteLine("GenericT1 is: {0}, GenericT2 is: {1}", t1, t2);
            Console.WriteLine("GenericT1 Type is: {0}, GenericT2 Type is: {1}", t1.GetType().Name, typeof(T2).Name);//option check from Value{t1.GetType()} or check from Type{typeof(T2)} | without .Name system will generate .FullName by default
        }

        public T2 outputT2WithInpuutT1<Ti>(Ti ti)
        {
           
            if (t1.Equals(ti))//check T1(Type From Class) == Ti(Type From Function)
            {
                return t2;
            }
            else if (t1.GetType().Equals(ti.GetType()))//check T1(Type From Class) == Ti(Type From Function)
            {
                //return t2; //try this
            }
            return default(T2);//need to return something so use Default value
        }
    }
}
