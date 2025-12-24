using System;

namespace PracticeCsharp
{
  class PlayerHealth
  {

    public static int Health()
    {
      int health = 20; // Initial player health

      if (health <= 0)
      {
        Console.WriteLine("Player is dead.");
        return 0; // Player is dead
      }
      else
      {
        Console.WriteLine($"Player health is {health}.");
        return health; // Return current health
      }
    }
  }
}