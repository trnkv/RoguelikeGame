using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    abstract class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GameObject(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Interaction()
        {
            //
        }
    }
}
