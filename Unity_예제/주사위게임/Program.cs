using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 주사위게임
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tile_max = 20;

            TileMap Map = new TileMap();
            Map.MapSetup(Tile_max);


        }

        static void Print_info()
        {
            Console.WriteLine("현재 타일의 개수 : ");

        }
    }
}
