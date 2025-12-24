using System;

namespace PracticeCsharp
{
  class RedDice
  {
    private double[] redDice = { 1, 2, 3, 4, 5, 6 };
    private Random random = new Random();

    public double RedDiceRoll()
    {
      return redDice[random.Next(redDice.Length)];
    }

    /**
    Adds to damage based on the value of the red dice roll
    If roll is 1, add 10% to damage
    If roll is 2, add 20% to damage
    etc...
    **/
    public double AddToDamage(double baseDamage)
    {
      double roll = RedDiceRoll();   // 1–6
      double multiplier = roll * 0.10; // 10% per roll

      return baseDamage * (1 + multiplier);
    }

    public double AddToUpgrade1(double baseDamage)
    {
      if (RedDiceRoll() == 6)
      {
        return baseDamage * 2; // Double damage on roll of 6
      } else
      {
        return baseDamage;
      }
    }

    public double AddToUpgrade2(double baseDamage)
    {
      if (skillPracticeCsharp.RollTheDie.playerFiles.playerHealth.PlayerHealth.Health() < 10)
      {
        return baseDamage * 1.5; // Increase damage by 50% if health is below 10
      } else
      {
        return baseDamage;
      }
    }

    public double AddToUpgrade3(double baseDamage)
    {
      if (skillpointshowevermany)
      {
        RedDice [0] = 2;
      }
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