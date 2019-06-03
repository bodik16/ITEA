using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HimeTask2_Cards
{
   public class Slot
    {
        List<Card> SLOT = new List<Card>();
        public int NumberOfCardsWhichAreReady;
        public int NumberOfCards;
        public Slot(int numCards, int numReady)
        {
            NumberOfCards = numCards;
            NumberOfCardsWhichAreReady = numReady;
        }
        public void ADDToSlot()
        {
            SLOT.Add(new Card());
        }
        public void REMOVEFromSlot(int n)
        {
            if (n < 0 & n > SLOT.Count)
            {
                Console.WriteLine($"Input number from 0 to {SLOT.Count}");
            }
            else
            SLOT.RemoveAt(n);
        }
    }
}
