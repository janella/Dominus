using System;
using System.Collections.Generic;
using Dominus.Libs.Contracts;

namespace Dominus.Libs
{
    public class PlayerDeck : IDeck
    {
        private Stack<ICard> Contents;

        public PlayerDeck()
        {
            Contents = new Stack<ICard>();
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
