using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            string inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool PlayAgain = true;

            while (PlayAgain)
            {

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("Choose between Sulinys, Popierius and Zirkles:  ");

                    inputPlayer = Console.ReadLine();
                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "Sulinys";
                            Console.WriteLine("Computer chose Sulinys");
                            if (inputPlayer == "Sulinys")
                            {
                                Console.WriteLine("DRAW\n");
                            }
                            else if (inputPlayer == "Popierius")
                            {
                                Console.WriteLine("PLAYER WINS\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Zirkles")
                            {
                                Console.WriteLine("CPU WINS\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "Popierius";
                            Console.WriteLine("Computer chose Popierius");
                            if (inputPlayer == "Popierius")
                            {
                                Console.WriteLine("DRAW\n");
                            }
                            else if (inputPlayer == "Sulinys")
                            {
                                Console.WriteLine("CPU WINS\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "Zirkles")
                            {
                                Console.WriteLine("PLAYER WINS\n");
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputCPU = "Zirkles";
                            Console.WriteLine("Computer chose Zirkles");
                            if (inputPlayer == "Zirkles")
                            {
                                Console.WriteLine("DRAW\n");
                            }
                            else if (inputPlayer == "Sulinys")
                            {
                                Console.WriteLine("PLAYER WINS\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "Popierius")
                            {
                                Console.WriteLine("CPU WINS\n");
                                scoreCPU++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry");
                            break;
                    }
                    Console.WriteLine("Scores:\nPlayer: {0}\nCPU: {1}",scorePlayer, scoreCPU);


                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("PLAYER WIN");
                    scorePlayer = 0;
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WIN");
                    scoreCPU = 0;

                }
                else
                {

                }
                Console.WriteLine("Want to play again? y/n");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    
                    PlayAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    PlayAgain = false;
                }
                else
                {
                    break;
                }

            }
        }
    }
}
