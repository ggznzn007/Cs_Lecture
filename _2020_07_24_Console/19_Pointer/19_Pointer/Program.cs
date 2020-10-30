using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* C#은 포인터를 CLR(Common Language Runtime): 가상머신
 * == .NET Framework 내부에 사용하지만
 * 일반 프로그래밍에서는 거의 사용하지 않는다.
 * 
 * 다만 MS의 전통적인 SW가 C/C++ 기반이 매우 많으므로
 * 이전의 소프트웨어 기능을 가져다 쓰기 위해서
 * 포인터를 지원하기로 결정했다.
 * 
 * 그래서 C#에서도 포인터를 사용할 수는 있다.
 * 하지만 권장사항은 아니다
 *  
 * Why ? 포인터는 주소를 통해 직접 메모리를 접근하는 방식이므로
 *      CLR에 의해 관리되지 않기 때문에
 *      에러의 위험성이 항상 존재한다.
 *      
 * 그래서 사용하려면 2중장치를 해제해야 한다.
 * 1) 속성 > 빌드 > 안전하지 않은 코드 허용 check
 * 2) unsafe {} 블록 안에서만 포인터 사용할 수 있다.
 
 */

namespace _19_Pointer
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3, j;
            unsafe
            {
                int* pi;
                pi = &i;
                j = *pi;
            }
            Console.WriteLine("i={0}, j={1}", i, j);
        }
    }
}
