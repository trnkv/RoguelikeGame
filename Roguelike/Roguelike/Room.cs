using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    class Room
    {
        public int Width = 10;   // длина
        public int Height = 10;  //ширина
        public int Number;       //номер

        public Room(int Number)
        {
            this.Number = Number;
        }
    }
}
