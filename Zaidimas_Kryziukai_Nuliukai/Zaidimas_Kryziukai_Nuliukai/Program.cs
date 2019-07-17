using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Kryziukai_Nuliukai
{
    class Program
    {
        static void Main(string[] args)
        {
            game Game = new game();
            Game.PlayGame();
            Console.WriteLine("Game Over");
        }
    }
}
