using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_Struct.Erum
{
    enum Difficulty
    {
        Easy,
        Normal,
        Hard
    }
    struct Problem
    {
        public string Message;
        public int Answer;

        public Problem(string message, int answer)
        {
            Message = message;
            Answer = answer;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Double score = 0;
            Difficulty DifficultyLevel = 0;
            
            Menu(score, DifficultyLevel);

        }

        static void Menu(double score, Difficulty SelectDifficulty)
        {
            int choosePage;

            Console.WriteLine("Score : {0}, Difficulty : {1}", score, SelectDifficulty );
            CheckZeroToTwo(out choosePage);

            if (choosePage == 0)
            {
                PlayGamePage(score, SelectDifficulty);
            }
            else if (choosePage == 1)
            {
                SettingPage(score, SelectDifficulty);
            }
            else if (choosePage == 2)
            {
                Console.ReadLine();
            }
            
        }

        static void CheckZeroToTwo(out int page)
        {
            do
            {
                page = int.Parse(Console.ReadLine());

                if (page != 0 && page != 1 && page != 2)
                {
                    Console.WriteLine("Please input 0-2. ");
                }
            } while (page != 0 && page != 1 && page != 2);
        }

        static void PlayGamePage(double score, Difficulty difficultyLevel)
        {
            double Answer;
            double Qc = 0;
            double Qa;
            int d = (int)difficultyLevel;

            Problem[] RandomProblems = GenerateRandomProblems((d * 2) + 3);
            long timeStart = DateTimeOffset.Now.ToUnixTimeSeconds();

            for (int i = 0; i < RandomProblems.Length; i++)
            {
                Console.Write(RandomProblems[i].Message);
                Console.WriteLine();

                Answer = int.Parse(Console.ReadLine());
                if (Answer == RandomProblems[i].Answer)
                {
                    Qc += 1;
                }
            }

            long timeStop = DateTimeOffset.Now.ToUnixTimeSeconds();
            long averageTime = timeStop - timeStart;

            Qa = (d * 2) + 3;

            score += (((Qc / Qa) * (25 - Math.Pow(d,2)) / Math.Max(averageTime, 25 - Math.Pow(d, 2))) * (Math.Pow((2 * d) + 1,2)));

            Menu(score, difficultyLevel);
        }

        static void SettingPage(double score, Difficulty difficultLevel)
        {
            int CheckDifficulty;
            Console.WriteLine("Score : {0}, Difficulty : {1}.", score, difficultLevel);

            do
            {
                CheckDifficulty = int.Parse(Console.ReadLine());

                if (CheckDifficulty != 0 && CheckDifficulty != 1 && CheckDifficulty != 2)
                {
                    Console.WriteLine("Please input 0-2. ");
                }
            } while (CheckDifficulty != 0 && CheckDifficulty != 1 && CheckDifficulty != 2);

            difficultLevel = (Difficulty)CheckDifficulty;
            Menu(score, difficultLevel);

        }
        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }

            return randomProblems;
        }

    }
}
