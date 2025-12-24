using System;

namespace PracticeCsharp
{
  class EnemyDamage
  {
    public static int Damage()
    {
      Random random = new Random();
      return random.Next(3, 5); // Random damage between 3 and 5
    }
  }
}