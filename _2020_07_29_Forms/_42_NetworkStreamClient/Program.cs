﻿using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;

namespace _42_NetworkStreamClient
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 게임을 즐기고 싶은 고객이 강원랜드를 찾아가듯이
             * 주소를 가지고 서버에 접속을 해야 한다.
             */
            const string IP = "10.89.30.133";  // 나 자신의 주소
            const int PORT = 9000;

            Socket clientSocket = new Socket(
                        AddressFamily.InterNetwork,
                        SocketType.Stream,
                        ProtocolType.Tcp);
            // 찾아가야할 서버의 주소 객체를 생성
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            // 서버에 접속 요청
            clientSocket.Connect(ipep);

            // 서버에 데이터를 전송하자
            NetworkStream ns = new NetworkStream(clientSocket);
            StreamWriter sw = new StreamWriter(ns);

            string data = "종섭아 들리니~!!!!@????";
            sw.WriteLine(data);
            sw.Flush();     // 즉시 전송해라

            clientSocket.Close();
        }
    }
}
