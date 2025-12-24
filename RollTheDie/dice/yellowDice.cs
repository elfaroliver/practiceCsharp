using System;

namespace PracticeCsharp
{
  class YellowDice
  {
    static void Main(string[] args)
    {
      // Your code will go here

    }

    public bool HasFiveSkillPoints()
    {
      if (skillPoints >= 5)
      {
        return true;
      }
    }

    public double limelightUpgrade(double baseDamage)
    {
      AddToDamage(baseDamage);
      RedDiceRoll();

      if (HasFiveSkillPoints())
      {
        return baseDamage * 1.5; // 50% more damage
      }
    }

    public static bool weakEnemy()
    {
      return true;
    }
    
    public static int YellowDiceAbility()
    {
      if (weakEnemy())
      {
        return 3;
      }
      else
      {
        return 1;
      }
    }
  }
}