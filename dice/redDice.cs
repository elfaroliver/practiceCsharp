using System;

namespace PracticeCsharp
{
  class RedDice
  {
    public int RedDiceRoll()
    {
      int[] redDice = [2, 2, 3, 4, 5, 6];
      Random random = new Random();
      return redDice[random.Next(0, redDice.Length)];
    }

    public bool IsEvenRoll()
    {
      int roll = RedDiceRoll();
      return roll % 2 == 0;
    }

    public bool IsOddRoll()
    {
      int roll = RedDiceRoll();
      return roll % 2 != 0;
    }

    public bool IsHighRoll()
    {
      int roll = RedDiceRoll();
      return roll >= 4;
    }

    public bool IsLowRoll()
    {
      int roll = RedDiceRoll();
      return roll <= 3;
    }
  }
}