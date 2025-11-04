using System;

namespace PracticeCsharp
{
  class BlueDice
  {
    static void Main(string[] args)
    {
      // Your code will go here

    }

    public static bool bounceOff()
    {
      return true;
    }
    
    public static int BlueDiceAbility()
    {
      if (bounceOff())
      {
        enemyDamage = enemyDamage - 2;
        return enemyDamage;
      }
      else
      {
        return enemyDamage;
      }
    }
  }
}