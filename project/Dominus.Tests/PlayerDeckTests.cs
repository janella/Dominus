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

            Assert.Equal(10, newDeck.Count());
        }
    }
}
