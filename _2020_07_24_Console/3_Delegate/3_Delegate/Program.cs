using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_Delegate
{
    class Archive
    {
        public static void SendPacket(int nFile)
        {
            for (int i = 0; i < nFile; i++)
            {
                Console.WriteLine("{0}번째 패킷을 전송중...",
                    i + 1);
                System.Threading.Thread.Sleep(500);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Archive.SendPacket(100);
            Console.WriteLine("모든 패킷을 전송했습니다");
        }
    }
}
