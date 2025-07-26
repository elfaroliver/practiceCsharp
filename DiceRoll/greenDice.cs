using System;

namespace PracticeCsharp
{
  class GreenDice
  {
    public int GreenDiceRoll()
    {
      int[] greenDice = new int[] { 1, 2, 3, 4, 5, 6 };
      Random random = new Random();
      return greenDice[random.Next(0, greenDice.Length)];
    }
  }
}