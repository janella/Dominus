using System;
using System.Collections.Generic;
using Dominus.Libs.Contracts;

namespace Dominus.Libs
{
    public class PlayerDeck : IDeck
    {
        private Stack<ICard> Contents;
        public int Count
        {
            get { return Contents.Count; }
        }

        public PlayerDeck()
        {
            Contents = new Stack<ICard>();
            Contents.Push(new Card("Copper", "Treasure", 0)); // x7
            Contents.Push(new Card("Estate", "Victory", 2)); // x3
        }

        public ICard Draw()
        {
            var top = Contents.Pop();
            return top;
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}
