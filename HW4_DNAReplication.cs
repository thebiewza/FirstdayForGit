using System;

namespace Homework_4
{
    class Program
    {
        static void DNAReplication()
        {
            string DNA = Console.ReadLine();

            if ((IsValidSequence(DNA)) == true)
            {
                Console.WriteLine("Current half DNA sequence : {0}", DNA);

            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid. ");
                CheckSequence();
            }

            CheckReplicate(DNA);
            Console.ReadLine();
        }   

        static void CheckReplicate(string DNA)
        {
            Console.Write("Do you want  to replicate it ? (Y/N) : ");
            string checkReplicate = Console.ReadLine();
                
            switch (checkReplicate)
            {
                case ("Y"):
                    Console.WriteLine("Replicated half DNA sequence : {0}", (ReplicateSeqeunce(DNA)));
                    CheckSequence();
                    break;
                case ("N"):
                    CheckSequence();
                    break;
                default:
                    Console.WriteLine("Please input Y or N.");
                    CheckReplicate(DNA);
                    break;
                }
        }   

        static void CheckSequence()
        {
            Console.Write("Do you want to process another sequence ? (Y/N) : ");
            string checkSequence = Console.ReadLine();

            switch (checkSequence)
            {
                case ("Y"):
                    DNAReplication();
                    break;
                case ("N"):

                    break;
                default:
                    Console.WriteLine("Please input Y or N.");
                    CheckSequence();
                    break;
            }
            Console.ReadLine();
        }

        
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }


    }
}
