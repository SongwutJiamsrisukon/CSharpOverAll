using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasTu
{
    class MyGenericSubClass1<Ts,T> : MyGenericSuperClass<T>
    {
        public Ts genericSubMemberVariable;
        public MyGenericSubClass1(Ts valueSub, T value) : base(value)//need to set T to parent
        {
            genericSubMemberVariable = valueSub;
        }

        public override T print()
        {
            Console.WriteLine("Return parent type: {0}, parent value: {1}", typeof(T).ToString(), genericMemberVariable);
            Console.WriteLine("Return child type: {0}, child value: {1}", typeof(Ts).ToString(), genericSubMemberVariable);
            return genericMemberVariable;
        }
    }

    class MyGenericSubClass2 : MyGenericSuperClass<string>
    {
        public int genericSubMemberVariable;
        public MyGenericSubClass2(int valueSub, string value) : base(value)//need to set T to parent
        {
            genericSubMemberVariable = valueSub;
        }

        public override string print()
        {
            Console.WriteLine("Return parent type: {0}, parent value: {1}", typeof(string).ToString(), genericMemberVariable);
            Console.WriteLine("Return child type: {0}, child value: {1}", typeof(int).ToString(), genericSubMemberVariable);
            return genericMemberVariable;
        }
    }
}
