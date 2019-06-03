using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask__Lesson3
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

        public void ADDToSlot(Card a)
        {
            SLOT.Add(a);
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

        public void Print()
        {
            for (int i = 0; i < SLOT.Count; i++)
            {
                Console.WriteLine($"Card from Slot: {SLOT[i]}"); 
            }
        }

    }
}
