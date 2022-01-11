using System;
using System.Threading;
using System.Collections.Generic;

namespace 말달리기_kdw
{

    class Program
    {
        static void Main(string[] args)
        {
            horse[] arr_horse = new horse[5];
            int len = arr_horse.Length;

            List<string> rank = new List<string>();
           

            for (int i = 0; i < len; i++)
            {
                arr_horse[i] = new horse();
                arr_horse[i].name = $"{i + 1}번마";
                arr_horse[i].distance = GetRand();
            }

            while (rank.Count < 5)
            {

                for (int j = 0; j < len; j++)
                {
                    Call_IsFinsh(arr_horse[j].distance, j);
                }

                for (int i = 0; i < len; i++)
                {
                    if (arr_horse[i].distance >= 200)
                    {
                        rank.Add(arr_horse[i].name);
                        arr_horse[i].distance = 0;
                    }
                    int temp = GetRand();
                    arr_horse[i].distance = arr_horse[i].run(arr_horse[i].distance, temp);
                }

                Console.WriteLine("-------------------------------");

                Thread.Sleep(1000);
                

            }

            Console.WriteLine("-----순위-----");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"{rank[i]}");
            }
        }

        static public int GetRand()
        {
            Random rand = new Random();
            int value = rand.Next(10, 21);
            return value;
        }

        static public void Call_IsFinsh(int value, int i)
        {
            if (value == 0)
                Console.WriteLine($"{i + 1}번마가 이동한 거리: 도착");
            else
                Console.WriteLine($"{i + 1}번마가 이동한 거리: {value}m");
        }




    }
}
