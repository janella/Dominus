using System;

namespace Dominus.Libs.Contracts
{
    public interface ICard
    {
        string Name { get; }
        string Type { get; }
        int Cost { get; }
    }
}
