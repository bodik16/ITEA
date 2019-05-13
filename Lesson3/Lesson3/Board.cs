using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    public enum CardType
    {
       Ace, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen,King
    }
   public enum Rank
    {
        Club, Diamonds, Heart, Spade
    }
    public class Board
    {
        public List<Card> Koloda = new List<Card>();
        public List<Slot> slotss = new List<Slot>();

        public Board(int numberOfSlots)
        {

        }

        public void AddSlot(Slot a)
        {
                slotss.Add(a);
        }
        public void AddCard(Card a)
        {
                Koloda.Add(a);
        }

        public void RemoveCard(int num)
        {
            Koloda.RemoveAt(num);
        }
        public override string ToString()
        {
            return $"Number of Slots: {slotss.Count} | Number of Cards: {Koloda.Count}";
        }
    }


}
