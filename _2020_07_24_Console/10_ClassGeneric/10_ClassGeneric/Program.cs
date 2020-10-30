using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Generic == Template
 * 자료형은 다르고 논리는 동일할 때 
 * 1번만 구현해서 여러 자료형을 
 * 대입하면서 사용하자
 * 
 * 자료구조/알고리즘
 */

namespace _10_ClassGeneric
{
    class WrapperInt
    {
        int Value;
        public WrapperInt() { Value = 0; }
        public WrapperInt(int aValue)
        { Value = aValue; }
        public int Data
        {
            get { return Value; }
            set { Value = value; }
        }
        public void OutValue()
        {
            Console.WriteLine(Value);
        }
    }

    class WrapperString
    {
        string Value;
        public WrapperString() { Value = null; }
        public WrapperString(string aValue)
        { Value = aValue; }
        public string Data
        {
            get { return Value; }
            set { Value = value; }
        }
        public void OutValue()
        {
            Console.WriteLine(Value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WrapperInt gi = new WrapperInt(1234);
            gi.OutValue();
            WrapperString gs = new WrapperString("문자열");
            gs.OutValue();
        }
    }
}
