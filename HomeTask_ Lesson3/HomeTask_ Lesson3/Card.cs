using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask__Lesson3
{
    public enum CardType
    {
        Ace, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }
    public enum CardRank
    {
        Clubs, Diamonds, Hearts, Spades
    }
    public class Card
    {
        public bool isReady = false;
        public CardType cardType;
        public CardRank cardRank;
        public Card()
        {

        }
        public Card(CardType type, CardRank rank)
        {
            cardType = type;
            cardRank = rank;

        }
        public override string ToString()
        {
            return $"Crad Type: {cardType} | Card Rank: {cardRank} | Ready: {isReady}";
        }
    }
}
