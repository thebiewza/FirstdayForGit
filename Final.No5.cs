using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.No._5
{
    class Program
    {
        static void MyInventory()
        {
            int NumOfItem = int.Parse(Console.ReadLine());


            string[] NameItem;
            string[] TypeItem;

            for (int i = 0; i < NumOfItem; i++)
            {
                NameItem = new string[NumOfItem];
                TypeItem = new string[NumOfItem];
            }

            string Mode = Console.ReadLine();

            Console.ReadLine();
        }

        static void ModeToFindItem(string Mode, int num, string[] Name, string[] Type)
        {
            if (Mode == "ShowAll")
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    ModeToFindItem(Mode, num, Name, Type);
                }
            }
            else
            {

            }
        }
    }
}
