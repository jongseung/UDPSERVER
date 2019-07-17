using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

// DP : 비연결형 통신 방식, 서버와 클라이언트가 연결과정을 수행하지 않고 통신하는 방식
// 따라서 네트워크 상에서 데이터가 손시로디더라도 재전송 요청을 할 수 없음.
// UDP 서버 통신 기본 예제
// 기능
// UDP 클라이언트가 보낸 바이트배열을 문자열로 변환 및 출력

namespace UDPSERVER
{
    class Program
    {
        static void Main(string[] args)
        {

            // UDP 서버 생성 - socket 생성 및 bind
            UdpClient dup = new UdpClient();
            // 데이터 수신
            
            // 바이트 데이터를 문자열로 변환 및 출력

            //UDP 서버 닫기
        }
    }
}
