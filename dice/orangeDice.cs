using System;

namespace PracticeCsharp
{
  class OrangeDice
  {

  /** 
  The armor value of the Orange Dice 
  Starts at 5 and probably won't go over 10, ever
  */  
  public int Armor = 5;

  static void Main(string[] args)
  {
    // Your code will go here

  }

    /** Increases armor by 1 each turn if PlusPerTurn() is true */
  public static int increaseArmorPerTurn() {
    if (PlusPerTurn())
    {
      Armor = Armor + 1;
    }
  }
  public static bool PlusPerTurn() {
    return true;
  }

  public static int Armor { get; set; }

  }
}