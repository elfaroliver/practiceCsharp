using System;

namespace PracticeCsharp
{
  class RedDice
  {
    public int RedDiceRoll()
    {
      int[] redDice = new int[] { 2, 2, 3, 4, 5, 6 };
      Random random = new Random();
      return redDice[random.Next(0, redDice.Length)];
    }
  }
}