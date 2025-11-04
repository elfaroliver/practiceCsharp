using System;

namespace PracticeCsharp
{
  class GreenDice
  {
    public int GreenDiceRoll()
    {
      int[] greenDice = [1, 2, 3, 4, 5, 6];
      Random random = new Random();
      return greenDice[random.Next(0, greenDice.Length)];
    }

    public bool IsEvenRoll()
    {
      int roll = GreenDiceRoll();
      return roll % 2 == 0;
    }

    public bool IsOddRoll()
    {
      int roll = GreenDiceRoll();
      return roll % 2 != 0;
    }

    public bool IsHighRoll()
    {
      int roll = GreenDiceRoll();
      return roll >= 4;
    }

    public bool IsLowRoll()
    {
      int roll = GreenDiceRoll();
      return roll <= 3;
    }
  }
}