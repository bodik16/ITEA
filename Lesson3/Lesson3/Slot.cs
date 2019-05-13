using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
   public class Slot
    {
      public List<Card> Slots = new List<Card>();
       private int numberOfCurds;
        public Slot(int num)
        {
            numberOfCurds = num;
        }

        public void AddCards( Card a)
        {
                Slots.Add(a);
        }
        public void RemoveCard(int num)
        {
                Slots.RemoveAt(num);
        }

        public override string ToString()
        {
            return $"Number of Cards: {numberOfCurds}";
        }
    }
}
