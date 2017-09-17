using System;
using Dominus.Libs.Contracts;

namespace Dominus.Libs
{
    public class Card : ICard
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Cost { get; private set; }
        public Card(string name, string type, int cost)
        {
            Name = name;
            Type = type;
            Cost = cost;
        }
    }
}
