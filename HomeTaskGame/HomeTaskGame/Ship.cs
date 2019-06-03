using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskGame
{
    class Ship
    {
        private bool isAlive;
        private int length;

        public bool IsAlive { get => isAlive; set => isAlive = value; }
        public int Length { get =>length; set=>length = value; }
        public Ship(bool a, int l)
        {
            IsAlive = a;
            Length = l;
        }
        public override string ToString()
        {
            return $"Ready:{IsAlive} || Length: {Length}";
        }

    }
}
