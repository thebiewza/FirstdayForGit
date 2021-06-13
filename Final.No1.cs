using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.No._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] input = new int[3, 3];
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    input[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < input.GetLength(0); i++)
            {
                Console.WriteLine("{0} {1} {2}", input[i, 0], input[i, 1], input[i, 2]);
            }

            int replace = int.Parse(Console.ReadLine());


            Console.ReadLine();
        }
    }
}
