using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23_varType
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 5;
            var str = "문자열";
            Console.WriteLine(x.GetType().ToString());
            Console.WriteLine(str.GetType().ToString());
            Console.SetCursorPosition(x, y);
            Console.WriteLine(str);
        }
    }
}
