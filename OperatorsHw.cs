using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatersHW
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n;
            string input ;

            Console.Write("Input your Agency : ");
            input = Console.ReadLine();
            
            if (input == "CIA")
            {
                Console.Write("Input your Password in 6 digit : ");
                n = int.Parse(Console.ReadLine());

                if (n < 1000000)
                {
                    if ((n % 10) % 3 == 0)
                    {
                        if ((n / 10) % 10 != 1 && (n / 10) % 10 != 3 && (n / 10) % 10 != 5)
                        {

                            if ((n / 1000) % 10 == 6 || (n / 1000) % 10 == 7)
                            {

                                Console.WriteLine("True");

                            }
                            else
                            {
                                Console.WriteLine("False");
                            }

                        }
                        else
                        {
                            Console.WriteLine("False");
                        }

                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                else if (n >= 1000000)
                {
                    Console.WriteLine("Your password is Wrong.");
                }
                

            }
            

            else if (input == "FBI")
            {
                Console.Write("Input your Password in 6 digit : ");
                n = int.Parse(Console.ReadLine());
                
                if (n/100000 == 4 || n / 100000 == 5 || n / 100000 == 6 || n / 100000 == 7)
                {
                    if (((n / 100) % 10) % 2 == 0 && ((n / 100) % 10) != 6)
                    {
                        if (((n / 10000) % 10) % 2 == 1)
                        {
                            Console.WriteLine("Y");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }
            }


            else if (input == "NSA")
            {
                Console.Write("Input your Password in 6 digit : ");
                n = int.Parse(Console.ReadLine());

                if (n % 10 == 1 || n % 10 ==2 || n % 10 == 3 || n % 10 == 5 || n % 10 == 6)
                {
                    if (((n / 100) % 10) % 3 == 0 && ((n / 100) % 10) % 2 != 0)
                    {
                        if (n % 10 == 7 || (n / 10) % 10 == 7 || (n / 100) % 10 == 7 || (n/1000)%10 == 7 ||(n/10000)%10 == 7 || n/100000 == 7 )
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("False");
                }

            }

            else
            {
                Console.WriteLine("Your Password is Wrong.");
            }

 
            Console.ReadLine();
            
        


                                                    //1.1// (n % 10)% 3 == 0
                                                    //1.2// ((n/10)%10) != 1,3,5
                                                    //1.3// 6 <= (n/1000)%10 > 8

                                                    //2.1// 4 <= n/100000 >= 7
        }                                           //2.2// ((n/100)%10)%2 == 0 && != 6 
    }                                               //2.3// ((n/10000)%10)%2 == 1    

}                                                   //3.1// n % 10 == 1,2,3,5,6
                                                    //3.2// ((n/100)%10)%3 ==0 && ((n/100)%10)%2 != 0
                                                    //3.3// n%10 ==7 || (n/10)%10 == 7 || (n/100)%10 == 7
                                                    //      || (n/1000)%10 == 7 ||(n/10000)%10 == 7 || n/100000 == 7




