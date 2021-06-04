using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_No._2._3
{
    class Program
    {
       static void Main()
        {
            int binCount1 = int.Parse(Console.ReadLine());
            int binCount2 = int.Parse(Console.ReadLine());
            int binCount3 = int.Parse(Console.ReadLine());
            int turn = 0;
            while (binCount1 + binCount2 + binCount3 > 0)
            {
                int binIndex = int.Parse(Console.ReadLine());
                int boxCount = int.Parse(Console.ReadLine());
                switch (binIndex)
                {
                    case 1:
                        binCount1 -= boxCount;
                        break;
                    case 2:
                        binCount2 -= boxCount;
                        break;
                    case 3:
                        binCount3 -= boxCount;
                        break;
                    default:
                        break;
                }
                turn++;
            }
            if (turn % 2 == 0)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("B");
            }
            Console.ReadLine();

        }
    }
}
