using System;
using System.Collections.Generic;

namespace HomeTask__Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Hello World!");
            List<Slot> S = new List<Slot>();
            Deck deck = new Deck();
            Slot slot = new Slot(3, 2);
            Slot slot1 = new Slot(5, 4);
            Slot slot2 = new Slot(7, 1);
           
            slot.ADDToSlot(new Card(CardType.Eight, CardRank.Hearts));
            slot.ADDToSlot(new Card(CardType.One, CardRank.Spades));
            slot.ADDToSlot(new Card(CardType.Queen, CardRank.Hearts));
            Console.WriteLine("----------------------");
            slot.Print();
            Console.WriteLine("----------------------");
            slot1.ADDToSlot(new Card(CardType.Ten, CardRank.Clubs));
            slot1.ADDToSlot(new Card(CardType.Nine, CardRank.Hearts));
            slot1.ADDToSlot(new Card(CardType.Seven, CardRank.Hearts));
            slot1.ADDToSlot(new Card(CardType.Nine, CardRank.Spades));
            slot1.ADDToSlot(new Card(CardType.Ace, CardRank.Spades));
            S.Add(slot);
            S.Add(slot1);
            GameBoard gameBoard = new GameBoard(deck, S);

            //gameBoard.Print();
            Console.WriteLine("----------------------");
            Console.ReadKey();
        }
    }
}
