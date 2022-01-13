using System;
using System.Collections.Generic;
using System.Text;

namespace 주사위게임
{
    class TileInfo_Star : TileInfo
    {
        public int starValue = 1;

        public override void TileEvent()
        {
            base.TileEvent();
            starValue++;

        }
    }
}
