using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Kryziukai_Nuliukai
{
    class game
    {
        //naudojame jagged array

        private Square[][] _lenta = {
            new Square[3],
            new Square[3],
            new Square[3]
        };


        //Antras variantas su multi dimensional array
        //private Square[,] _board = new Square[3, 3];


        // Trecias  VARIANTAS SU Listais: 
        //private List<List<Square>> _lenta = new List<List<Square>>()
        //{
        //	new List<Square>{ new Square(), new Square(), new Square()},
        //	new List<Square>{ new Square(), new Square(), new Square()},
        //	new List<Square>{ new Square(), new Square(), new Square()}
        //};

        public void PlayGame()
        {
            Player zaidejas = Player.Kryziukai;

            bool tesinys = true;
            while (tesinys)
            {
                RodytiLenta();
                tesinys = Judesys(zaidejas);
                if (!tesinys)
                    return;
                zaidejas = 3 - zaidejas;


            }
        }
        private void RodytiLenta()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                
                    Console.Write(" " + _lenta[i][j]);
                    Console.WriteLine();
                

            }
        }
        private bool Judesys (Player zaidejas)
        {
            Console.WriteLine("\nNeteisingai ivedus bus nutrauktas zaidimas");
            Console.Write($"{zaidejas}: Iveskite eilute ir stulpeli: pvz: 2,3:  ");
            string input = Console.ReadLine();
            string[] parts = input.Split(',');
            if (parts.Length != 2)
                return false;

            int.TryParse(parts[0], out int eilute);
            int.TryParse(parts[1], out int stulpelis);

            if (eilute < 1 || eilute > 3|| stulpelis < 1 || stulpelis > 3)
                return false;
            if(_lenta[eilute-1][stulpelis-1].Normanas != Player.Niekas)
            {
                Console.WriteLine("Laukelis okupuotas!");
                Console.ReadLine();
                return false;
            }

            _lenta[eilute - 1][stulpelis - 1] = new Square(zaidejas);
            return true;

        }
    }
}
