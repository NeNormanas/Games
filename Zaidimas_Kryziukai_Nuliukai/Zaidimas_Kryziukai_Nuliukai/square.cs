using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas_Kryziukai_Nuliukai
{
    public enum Player { Niekas = 0, Nuliukai, Kryziukai}

    public struct Square // struct reiksia bus langelis empty by default
    {
       
        public Square(Player normanas)
        {
            this.Normanas = normanas;
        }
        public Player Normanas { get; }

        public override string ToString()
        {
            switch (Normanas)
            {
                case Player.Niekas:
                    return ".";
                case Player.Kryziukai:
                    return "X";
                case Player.Nuliukai:
                    return "O";
                default:
                    throw new Exception("Klaida");
            }
           
        }
    }
}
