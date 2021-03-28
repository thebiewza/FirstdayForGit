using System;

namespace MidTerm2_no._3_
{
    class Program
    {
        static void Main(string[] args)
        {

            //while (BoxT1 > 0 || BoxT2 > 0 || BoxT3 > 0)
            //{

            //    int chooseTankA;
            //    Console.Write("PlayerA, Choose the tank 1-3 : ");
            //    chooseTankA = int.Parse(Console.ReadLine());

            //    int boxA;
            //    Console.Write("PlayerA, Choose the box out : ");
            //    boxA = int.Parse(Console.ReadLine());

            //    switch (chooseTankA)
            //    {
            //        case (1):
            //            BoxT1 = BoxT1 - boxA;
            //            break;
            //        case (2):
            //            BoxT2 = BoxT2 - boxA;
            //            break;
            //        case (3):
            //            BoxT3 = BoxT3 - boxA;
            //            break;
            //    }
            //    Console.WriteLine("Box1 : {0} Box2 : {1} Box3 : {2}", BoxT1, BoxT2, BoxT3);
            //    Console.WriteLine();

            //    int chooseTankB;
            //    Console.Write("PlayerB, Choose the tank 1-3: ");
            //    chooseTankB = int.Parse(Console.ReadLine());

            //    int boxB;
            //    Console.Write("PlayerB, Choose the box out : ");
            //    boxB = int.Parse(Console.ReadLine());

            //    switch (chooseTankB)
            //    {
            //        case (1):
            //            BoxT1 = BoxT1 - boxB;
            //            break;
            //        case (2):
            //            BoxT2 = BoxT2 - boxB;
            //            break;
            //        case (3):
            //            BoxT3 = BoxT3 - boxB;
            //            break;
            //    }
            //    Console.WriteLine("Box1 : {0} Box2 : {1} Box3 : {2}", BoxT1, BoxT2, BoxT3);
            //    Console.WriteLine();

            //}

            //if (turn % 2 == 0)
            //{
            //    Console.WriteLine("The Winner is PlayerA");
            //}
            //else if (turn % 2 != 0)
            //{
            //    Console.WriteLine("The Winner is PlayerB");
            //}
            //Console.WriteLine(turn);

            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------------------

            int BoxT1;
            Console.Write("Input box in tank 1 : ");
            BoxT1 = int.Parse(Console.ReadLine());

            int BoxT2;
            Console.Write("Input box in tank 2 : ");
            BoxT2 = int.Parse(Console.ReadLine());

            int BoxT3;
            Console.Write("Input box in tank 3 : ");
            BoxT3 = int.Parse(Console.ReadLine());

            int turn = 0;

            Console.WriteLine();

            //-----------------------------------------------------------

            while (BoxT1 > 0 || BoxT2 > 0 || BoxT3 > 0)
            {
                turn++;
                if (turn % 2 != 0)
                {
                    Console.WriteLine("Player A");
                }
                else
                {
                    Console.WriteLine("Player B");
                }
                int chooseTank;
                Console.Write("Choose the tank 1-3: ");
                chooseTank = int.Parse(Console.ReadLine());

                int box;
                Console.Write("Choose the box out : ");
                box = int.Parse(Console.ReadLine());

                switch (chooseTank)
                {
                    case (1):
                        BoxT1 = BoxT1 - box;
                        break;
                    case (2):
                        BoxT2 = BoxT2 - box;
                        break;
                    case (3):
                        BoxT3 = BoxT3 - box;
                        break;
                }
                Console.WriteLine("Box1 : {0} Box2 : {1} Box3 : {2}", BoxT1, BoxT2, BoxT3);
                Console.WriteLine();

                

            }

            if (turn % 2 == 0)
            {
                Console.WriteLine("The Winner is PlayerA");
            }
            else if (turn % 2 != 0)
            {
                Console.WriteLine("The Winner is PlayerB");
            }

            Console.ReadLine();

        }
    }
}
