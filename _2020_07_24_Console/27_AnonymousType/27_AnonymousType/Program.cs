using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27_AnonymousType
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Human(string aName, int aAge)
        {
            Name = aName;
            Age = aAge;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human Lee = new Human("이순신", 32);
            Console.WriteLine("이름 : " +
                Lee.Name + ", 나이 : " + Lee.Age);
        }
    }
}
