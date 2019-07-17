using System;

namespace Sweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Input();

            int[,] resultArray = arrOfData(inputArray);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(resultArray[i, j] + " ");

                }
                Console.WriteLine();
            }

            Console.ReadKey();




        }

        static string[] Input()
        {
            string[] masyvas = new string[3];
            int input = 0;
            while (input != 3)
            {
                for (int i = 0; i < masyvas.Length; i++)
                {
                    Console.WriteLine("Iveskite eilutes duomenis");
                    masyvas[i] = Console.ReadLine();
                    input++;
                }
            }
            return masyvas;

        }

        static int[,] arrOfData (string[] arr)
        {
            char[] firstRow = arr[0].ToCharArray();
            char[] secondRow = arr[1].ToCharArray();
            char[] thirdRow = arr[2].ToCharArray();

            int[,] arejus = new int[3, 3];

            for (int i = 0; i < firstRow.Length; i++)
            {
                if (firstRow[i] == '*')
                {
                    arejus[0, i] = 1;
                }
                else if (firstRow[i] == '.')
                {
                    arejus[0, i] = 0;
                }

            }

            for (int i = 0; i < secondRow.Length; i++)
            {
                if (secondRow[i] == '*')
                {
                    arejus[1, i] = 1;
                }
                else if (secondRow[i] == '.')
                {
                    arejus[1, i] = 0;
                }

            }

            for (int i = 0; i < thirdRow.Length; i++)
            {
                if (thirdRow[i] == '*')
                {
                    arejus[2, i] = 1;
                }
                else if (thirdRow[i] == '.')
                {
                    arejus[2, i] = 0;
                }

            }
            return arejus;
        }
    }
}
