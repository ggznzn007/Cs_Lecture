using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14_GenericWhere
{
    // T는 데이터 타입이 struct여야 한다
    class Wrapper<T> where T : struct
    {
        T Value;
        public Wrapper() { Value = default(T); }
        public Wrapper(T aValue)
        { Value = aValue; }
        public T Data
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
            Wrapper<int> gi =
                new Wrapper<int>(1234);
            gi.OutValue();
            //Wrapper<string> gs =
            //    new Wrapper<string>("Hello");
            //gs.OutValue();
        }
    }
}
