using System;

namespace PracticeCsharp
{
  class YellowDice
  {
    static void Main(string[] args)
    {
      // Your code will go here

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