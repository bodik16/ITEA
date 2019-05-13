using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    public class Card
    {
        private CardType card;
        private Rank rank;
        string line;
        public Card()
        {
            card = CardType.King;
            rank = Rank.Diamonds;
        }
        public Card(CardType _cards, Rank _rank )
        {
            this.card = _cards;
            this.rank = _rank;
        }
        public override string ToString()
        {
            return $"Card value: {card} | Card rank: {rank}";
        }
    }
}
