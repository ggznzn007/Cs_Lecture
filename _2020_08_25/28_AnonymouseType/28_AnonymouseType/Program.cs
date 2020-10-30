using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28_AnonymouseType
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lee = new
            {
                Name = "이순신",
                Age = 32
            };

            Console.WriteLine(Lee.GetType().ToString());

            Console.WriteLine("이름 : " +
                Lee.Name + ", 나이 : "
                + Lee.Age);
        }
    }
}
