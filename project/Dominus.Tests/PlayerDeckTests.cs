using System;
using Dominus.Libs;
using Xunit;

namespace Dominus.Tests
{
    public class PlayerDeckTests
    {
        [Fact]
        public void NewDeckStartsWithTenCards()
        {
            var newDeck = new PlayerDeck();

            Assert.Equal(10, newDeck.Count);
        }

        [Fact]
        public void DrawMakesDeckOneLess()
        {
            var newDeck = new PlayerDeck();
            var originalCount = newDeck.Count;
            newDeck.Draw();

            Assert.Equal(originalCount - 1, newDeck.Count);
        }
    }
}
