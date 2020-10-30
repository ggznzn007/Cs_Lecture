using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _26_Chogija
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human Jang = new Human 
                    { Name = "장길산", Age = 32 };
            Console.WriteLine("이름 : " + Jang.Name
                        + ", 나이 : " + Jang.Age);
        }
    }
}
