using System;

namespace Homework_4
{
    class Program
    {
        static void Pascaltriangle()
        {
            int input = int.Parse(Console.ReadLine());
            
            int val = 0;

            if (input == 0)
            {
                Console.WriteLine("1");
            }
            else if (input > 0)
            {
                input = input + 1;
                for (int i = 0; i < input; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == 0)
                        {
                            val = 1;
                        }
                        else
                        {
                            val = val * (i - j + 1) / j;
                        }
                        Console.Write(val + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
                Pascaltriangle();
            }
        }

    }
}
