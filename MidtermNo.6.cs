using System;

namespace MidTermNo._5
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            int width = int.Parse(Console.ReadLine());
            int height= int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

           
            Step(letter,width,height,step);

            Console.ReadLine();
        }

        static void DrawBoxOfStep(char letter, int width, int height)
        {
            for (int h = 1; h <= height; h++)
            {
                for (int l = 1; l <= width; l++)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
            }
        }

        static void Step(char letter, int width, int height, int step)
        {
            for (int i = 1; i <= step;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    DrawBoxOfStep(letter, width, height);
                }
                Console.WriteLine();
            }
        }
    }
}
