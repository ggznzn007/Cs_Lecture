using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace _24_varType
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5 };

            foreach (var i in ar)
            {
                Console.WriteLine(i);
            }
        }
    }
}
