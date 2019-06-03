using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HimeTask2_Cards
{
   public class Deck
    {
        public List<int> d = new List<int>();
        public List<Card> DECK = new List<Card>();
        public Deck()
        {
            for (int i = 0; i < 56; i++)
            {
                d.Add(2);
                DECK.Add(new Card(CardType.One, CardRank.Clubs));
                DECK.Add(new Card(CardType.One, CardRank.Diamonds));
                DECK.Add(new Card(CardType.One, CardRank.Hearts));
                DECK.Add(new Card(CardType.One, CardRank.Spades));
                DECK.Add(new Card(CardType.Two, CardRank.Spades));
                DECK.Add(new Card(CardType.Two, CardRank.Clubs));
                DECK.Add(new Card(CardType.Two, CardRank.Diamonds));
                DECK.Add(new Card(CardType.Two, CardRank.Hearts));
                DECK.Add(new Card(CardType.Three, CardRank.Spades));
                DECK.Add(new Card(CardType.Three, CardRank.Clubs));
                DECK.Add(new Card(CardType.Three, CardRank.Diamonds));
                DECK.Add(new Card(CardType.Three, CardRank.Hearts));
                DECK.Add(new Card(CardType.Four, CardRank.Spades));
                DECK.Add(new Card(CardType.Four, CardRank.Clubs));
                DECK.Add(new Card(CardType.Four, CardRank.Diamonds));
                DECK.Add(new Card(CardType.Four, CardRank.Hearts));
                DECK.Add(new Card(CardType.Five, CardRank.Spades));
                DECK.Add(new Card(CardType.Five, CardRank.Clubs));
                DECK.Add(new Card(CardType.Five, CardRank.Diamonds));
                DECK.Add(new Card(CardType.Five, CardRank.Hearts));
                DECK.Add(new Card(CardType.Six, CardRank.Spades));
                DECK.Add(new Card(CardType.Six, CardRank.Clubs));
                DECK.Add(new Card(CardType.Six, CardRank.Diamonds));
                DECK.Add(new Card(CardType.Six, CardRank.Hearts));
                DECK.Add(new Card(CardType.Seven, CardRank.Spades));
                DECK.Add(new Card(CardType.Seven, CardRank.Clubs));
                DECK.Add(new Card(CardType.Seven, CardRank.Diamonds));
                DECK.Add(new Card(CardType.Seven, CardRank.Hearts));
                DECK.Add(new Card(CardType.Eight, CardRank.Spades));
                DECK.Add(new Card(CardType.Eight, CardRank.Clubs));
                DECK.Add(new Card(CardType.Eight, CardRank.Diamonds));
                DECK.Add(new Card(CardType.Eight, CardRank.Hearts));
                DECK.Add(new Card(CardType.Nine, CardRank.Spades));
                DECK.Add(new Card(CardType.Nine, CardRank.Clubs));
                DECK.Add(new Card(CardType.Nine, CardRank.Diamonds));
                DECK.Add(new Card(CardType.Nine, CardRank.Hearts));
                DECK.Add(new Card(CardType.Ten, CardRank.Spades));
                DECK.Add(new Card(CardType.Ten, CardRank.Clubs));
                DECK.Add(new Card(CardType.Ten, CardRank.Diamonds));
                DECK.Add(new Card(CardType.Ten, CardRank.Hearts));
                DECK.Add(new Card(CardType.Jack, CardRank.Spades));
                DECK.Add(new Card(CardType.Jack, CardRank.Clubs));
                DECK.Add(new Card(CardType.Jack, CardRank.Diamonds));
                DECK.Add(new Card(CardType.Jack, CardRank.Hearts));
                DECK.Add(new Card(CardType.Queen, CardRank.Spades));
                DECK.Add(new Card(CardType.Queen, CardRank.Clubs));
                DECK.Add(new Card(CardType.Queen, CardRank.Diamonds));
                DECK.Add(new Card(CardType.Queen, CardRank.Hearts));
                DECK.Add(new Card(CardType.King, CardRank.Spades));
                DECK.Add(new Card(CardType.King, CardRank.Clubs));
                DECK.Add(new Card(CardType.King, CardRank.Diamonds));
                DECK.Add(new Card(CardType.King, CardRank.Hearts));
                DECK.Add(new Card(CardType.Ace, CardRank.Clubs));
                DECK.Add(new Card(CardType.Ace, CardRank.Diamonds));
                DECK.Add(new Card(CardType.Ace, CardRank.Hearts));
                DECK.Add(new Card(CardType.Ace, CardRank.Spades));
            }
            
        }
    }
}
