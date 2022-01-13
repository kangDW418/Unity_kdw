using System;
using System.Collections.Generic;
using System.Text;

namespace 주사위게임
{
    class TileMap
    {
        public Dictionary<int, TileInfo> dic_tile = new Dictionary<int, TileInfo>();


        public void MapSetup(int maxTileNum)
        {
            for (int i = 1;i <= maxTileNum;i++)
            {
                if(i % 5 == 0)
                {
                    TileInfo tileInfo_star = new TileInfo();
                    tileInfo_star.index = i;
                    tileInfo_star.name = "샛별";
                    tileInfo_star.descript = "샛별 칸 입니다. 샛별을 1개 획득하였고, 다음에 이 칸에서 획득할 수있는 샛별개수가 1 증가합니다.";
                    dic_tile.Add(i, tileInfo_star);
                }
                else
                {
                    TileInfo tileInfo_Dummy = new TileInfo();
                    tileInfo_Dummy.index = i;
                    tileInfo_Dummy.name = "더미";
                    tileInfo_Dummy.descript = "더미 칸입니다. ";
                    dic_tile.Add(i, tileInfo_Dummy);

                }
            }
            Console.WriteLine($"맵 세팅이 완료되었습니다. 타일의 길이는 {maxTileNum}입니다 ");

            foreach(int a in dic_tile.Keys)
            {
                TileInfo tempValue = dic_tile[a];
                Console.WriteLine($"번호: {a}, 정보 : {tempValue}");
            }

        }

    }
}
