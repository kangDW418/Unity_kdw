using System;
using System.Collections.Generic;
using System.Text;

namespace 주사위게임
{
    class TileInfo
    {
        public int index;        // 몇번째 칸인지
        public string name;      // 칸에대한 설명
        public string descript;  // 칸에대한 설명


        virtual public void TileEvent()
        {
            Console.WriteLine($"타일 번호 : {index}, 타일 이름 : {name},  {descript}");
        }

        // 칸에 도착했을 때 실행 될 함수
    }
}
