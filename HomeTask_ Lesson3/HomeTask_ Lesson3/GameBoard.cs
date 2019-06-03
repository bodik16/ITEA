using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask__Lesson3
{
    class GameBoard
    {
        Deck deck = new Deck();
        List<Slot> slots = new List<Slot>();
        public GameBoard(Deck a, List<Slot> b)
        {
            deck = a;
            slots = b;
        }

        public void Print(List<Slot > a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine($"Slots: {a[i]}");
            }

        }

        //public override string ToString()
        //{
        //    for (int i = 0; i < length; i++)
        //    {
        //        return $"Slots: {slots.Print()}";
        //    }

        //}

        //Slot slot = new Slot();
    }
}
