using System;

namespace Dominus.Libs.Contracts
{
  public interface IDeck
  {
    Card Draw();
    void Shuffle();
  }
}
