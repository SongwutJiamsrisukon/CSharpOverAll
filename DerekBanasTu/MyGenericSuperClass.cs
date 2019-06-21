using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class MyGenericSuperClass<T>
    {
        public T genericMemberVariable;

        public MyGenericSuperClass(T value)
        {
            genericMemberVariable = value;
        }

        public virtual T print()
        {
            Console.WriteLine("Return parent type: {0}, parent value: {1}", typeof(string).ToString(), genericMemberVariable);
            return genericMemberVariable;
        }
    }
}
