using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace _5_Process
{
    class Program
    {
        static void Main(string[] args)
        {
            Process Proc = Process.Start("mspaint.exe");
            Thread.Sleep(5000);
            Proc.Kill();
        }
    }
}
