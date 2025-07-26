using System;

namespace PracticeCsharp
{
  class Program
  {
    static void Main(string[] args)
    {
      GreenDice greenDice = new GreenDice(); // Create an instance of GreenDice
      PlayerHealth playerHealth = new PlayerHealth(); // Create an instance of PlayerHealth
      
      RedDice redDice = new RedDice(); // Create an instance of RedDice
      EnemyHealth enemyHealth = new EnemyHealth(); // Create an instance of EnemyHealth

      Console.WriteLine("Welcome to the Dice Roll Game!");
      int health = PlayerHealth.Health(); // Call the health method to initialize player health 
      int enemyHealthValue = EnemyHealth.Health(); // Call the health method to initialize enemy health
      
      Console.WriteLine($"Initial player health: {health}");
      Console.WriteLine($"Initial enemy health: {enemyHealthValue}");
      while (health > 0 && enemyHealthValue > 0) {
        int healthIncrease = greenDice.GreenDiceRoll(); // Call the greenDiceRoll method to simulate a dice roll
        int playerDamage = redDice.RedDiceRoll(); // Call the redDiceRoll method to simulate a dice roll

        Console.WriteLine("");

        Console.WriteLine($"Health increase from dice roll: {healthIncrease}");
        int currentHealth = health += healthIncrease; // Simulate health increase by a dice roll
        if (currentHealth > 20) {
          currentHealth = 20; // Cap health at 20
        }
        Console.WriteLine($"Current player health after dice roll: {currentHealth}");
        
        int damage = EnemyDamage.Damage(); // Call the EnemyDamage method to simulate enemy damage
        Console.WriteLine($"Enemy damage dealt: {damage}");

        health -= damage; // Simulate health decrease due to enemy damage
        Console.WriteLine($"Player health after enemy damage: {currentHealth}");
        enemyHealthValue -= playerDamage; // Simulate enemy health decrease due to player damage
        Console.WriteLine($"Enemy health after player damage: {enemyHealthValue}");
      }
    }
  }
}