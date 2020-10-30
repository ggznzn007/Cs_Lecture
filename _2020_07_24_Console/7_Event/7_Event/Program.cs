using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*윈폼의 이벤트 핸들러는 delegate로 만든다.
 다만 delegate에 event키워드를 붙여준다.

 아래 예제에서는 event를 빼도 동작에는 영향을 안준다.
  
 다만 event키워드를 붙이는 이유는
 1) 외부에서 delegate 변수로 관련 정보를 얻을 수 없게 해서
   보안성을 유지하기 위함이다.
 2) 여러 개의 스레드에서 사용할 때 안전하게 사용할 수 있는 
   코드가 컴파일 시 자동으로 추가되기 때문이다.
*/

namespace _7_Event
{
    delegate void Notice();

    class Message
    {
        public void SendComplete()
        {
            Console.WriteLine("모두 전송했습니다.");
        }
    }

    class Sender
    {
        public Notice OnComplete;
        public void Send()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i += random.Next(20))
            {
                Console.WriteLine(i + "% 전송중");
                System.Threading.Thread.Sleep(random.Next(500)+100);
            }
            if (OnComplete != null)
                OnComplete();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Message M = new Message();
            Sender S = new Sender();

            // 이벤트 핸들러 등록
            // 전송이 완료되면 M.SendComplete
            // 자동으로 호출됨.
            S.OnComplete += M.SendComplete;
            S.Send();
        }
    }
}
