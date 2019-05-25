using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaFight
{
    class Board
    {
        List<Ship> MyShips = new List<Ship>();
        Board()
        {
            MyShips.Add(new SingleShip('A', 0));
            MyShips.Add(new SingleShip('A', 0));
            MyShips.Add(new SingleShip('A', 0));
            MyShips.Add(new SingleShip('A', 0));
            MyShips.Add(new TwiceShip());
            MyShips.Add(new TwiceShip());
            MyShips.Add(new TwiceShip());
            MyShips.Add(new TripleShip());
            MyShips.Add(new TripleShip());
            MyShips.Add(new QuadShip());
        }
    }
}
