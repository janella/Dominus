using System;

namespace Dominus.Libs.Contracts
{
    public interface IDeck
    {
        ICard Draw();
        void Shuffle();
        int Count { get; }
    }
}
