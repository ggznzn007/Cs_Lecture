using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Delegate
{
    class Archive
    {
        public delegate void SendProg(int nFile);
        public static void SendPacket(int nFile,
                                    SendProg Prog)
        {
            for (int i = 0; i < nFile; i++)
            {
                Prog(i);
                System.Threading.Thread.Sleep(500);
            }
        }
    }
    class Program
    {
        public static void Progress(int nFile)
        {
            Console.WriteLine("{0}번째 패킷을 전송중...",
                nFile + 1);
        }
        public static void EngProgress(int nFile)
        {
            Console.WriteLine("Now Sending {0} Packet. Wait Please",
                nFile + 1);
        }
        static void Main(string[] args)
        {
            Archive.SendPacket(10, Progress);
            Console.WriteLine("모든 패킷을 전송했습니다");
        }
    }
}
