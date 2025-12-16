using System;

namespace PracticeCsharp
{
  class RedDice
  {
    public int RedDiceRoll()
    {
      int[] redDice = [1, 2, 3, 4, 5, 6];
      Random random = new Random();
      return redDice[random.Next(0, redDice.Length)];

      //return random.Next(1, 7);
    }

    /**
    Adds to damage based on the value of the red dice roll
    If roll is 1, add 10% to damage
    If roll is 2, add 20% to damage
    etc...
    **/
    public double AddToDamage(double baseDamage)
{
    int roll = RedDiceRoll();   // 1–6
    double multiplier = roll * 0.10; // 10% per roll

    return baseDamage * (1 + multiplier);
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