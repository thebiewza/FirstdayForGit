using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.No._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumOfInput = int.Parse(Console.ReadLine());
            int[] input = new int[NumOfInput];

            for (int i = 0; i < NumOfInput; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            ///1
            Array.Sort(input);

            Console.Write("First Sort : ");
            foreach (int value in input)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();


            ////2
            input = input.OrderByDescending(c => c).ToArray();
            Array.Reverse(input);
            Console.Write("Second Sort : ");
            foreach (int value in input)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();


            ///3
            int temp;

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] < input[j])
                    {

                        temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            Array.Reverse(input);

            Console.Write("Third Sort : ");
            foreach (int value in input)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();


            ///4
            Array.Sort<int>(input, delegate (int m, int n)
            { return n - m; });

            Array.Reverse(input);

            Console.Write("Fourth Sort : ");
            foreach (int value in input)
            {
                Console.Write(value + " ");
            }

            Console.ReadLine();
        }
    }
}
