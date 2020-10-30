using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21_Nullrable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? Age;
            Age = null;
            if (Age.HasValue)
            {
                Console.WriteLine(Age);
            }
            else
            {
                Console.WriteLine("알 수 없는 나이임");
            }
        }
    }
}
