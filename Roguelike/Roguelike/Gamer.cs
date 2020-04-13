using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    class Gamer: GameObject, IMovable
    {
        public string Name;
        public int Health = 100;

        public Gamer(int X, int Y, string Name) : base(X, Y)
        {
            this.Name = Name;
        }

        public void Move()
        {
            X += 1;
        }
    }
}
