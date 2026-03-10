public class Witchbreed
{
  public string Name { get; set; }
  public int Health { get; set; }
  public int Attack { get; set; }
  public int Defense { get; set; }

  public Witchbreed(string name, int health, int attack, int defense)
  {
    Name = name;
    Health = health;
    Attack = attack;
    Defense = defense;
  }

  public int DealDamage()
  {
    return Attack;
  }

  public void TakeDamage(int damage)
  {
    int reducedDamage = damage - Defense;
    Health -= reducedDamage > 0 ? reducedDamage : 0;
  }

  public bool IsAlive()
  {
    return Health > 0;
  }
}