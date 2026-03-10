using System;

namespace PracticeCsharp
{
  class VioletDice
  {
    public int purpleShield = 5;
    public bool ricochetOff()
    {
      return true;
    }

    static void Main(string[] args)
    {
      // Your code will go here

    }
    
    public int decreaseEnemyDamage()
    {
      if (enemyDamage => 3)
      {
        enemyDamage = enemyDamage =- 1;
        return enemyDamage;
      }
      else
      {
        return enemyDamage;
      }
    }

    public int storeDamage()
    {
      int storedDamage = 0;

      if (storedDamage >= 50) 
      {
        playerDamage = storedDamage;
        return playerDamage;
      }

      if (enemyDamage => 3)
      {
        storedDamage = enemyDamage;
        return storedDamage;
      }
      else
      {
        return storedDamage;
      }
    }
  }
}