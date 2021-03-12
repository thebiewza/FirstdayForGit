using System;

namespace HWgraph
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            
            double timeX = double.Parse(Console.ReadLine());
            double priceY = double.Parse(Console.ReadLine());

            if (mode == "time" || mode == "price")
            {
                if (timeX < 0)
                {
                    Console.WriteLine("Invalid mouse position");
                }
                else if (mode == "time")
                {
                    priceY = Math.Pow((timeX - 1), 2);
                    Console.WriteLine("{0} , {1}",timeX , priceY);
                }
                else if (mode == "price")
                {
                    timeX = Math.Sqrt(priceY) + 1;
                    Console.WriteLine("{0} , {1}",timeX , priceY);
                }
            }
            else
            {
                Console.WriteLine("Invalid mode. ");
            }

            Console.ReadLine();

        }
    }
}
