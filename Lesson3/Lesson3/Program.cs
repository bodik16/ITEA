using System;

namespace Lesson3
{
    class Program
    {

        static void Main(string[] args)
        {
            //Slot a = new Slot(5);
            Slot slot = new Slot(2);
            Card a = new Card(CardType.Ace, Rank.Diamonds);
            Board board = new Board(10);
            board.AddSlot(slot);
            board.AddCard(new Card(CardType.Ace, Rank.Diamonds));

            Console.WriteLine(board);
            Console.WriteLine(a);
            Console.WriteLine(slot);

            //Board board = new Board(5);
            //foreach (var item in board)
            //{
            //}
            //Console.WriteLine(board);
            Console.ReadKey();
        }
    }
}
