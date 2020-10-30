using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _6_EnumProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] Procs = 
                Process.GetProcesses();
            foreach (Process p in Procs)
            {
                Console.WriteLine("ID={0,5}, "
                    + "이름={1}",
                    p.Id, p.ProcessName);
            }
        }
    }
}
