using System;



namespace 주사위게임_kdw
{
    class Program
    {
        static void Main(string[] args)
        {
            int star = 0;

            TileMap tileMap = new TileMap();

            while(star < 30)
            {
                int dice = GetRand();


            }



        }

        static public int GetRand()
        {
            Random rand = new Random();
            int value = rand.Next(1, 7);
            return value;
        }
    }
}
