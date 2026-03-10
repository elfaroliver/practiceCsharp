using System;

namespace PracticeCsharp
{

  public static class GeneralDiceRules
  {
    private static double[] blackDice = { 1, 2, 3, 4, 5, 6 };
    private static Random random = new Random();

    public static void RollDice(int length)
    {
      for (int i = 0; i < 10; i++)
      {
        blackDice[i] = blackDice[random.Next(blackDice.Length)];
      }
      
      for (int i = 10; i < length; i++)
      {
        blackDice[i] = blackDice[random.Next(blackDice.Length)] + 1;
      }
    }

    public static void Main(string[] args)
    {
      RollDice(20);
    }

    public static int blackDie()
    {
      double[] blackDice = { 0, 1, 2, 3, 4, 5, };
      for (int i = 0; i < blackDice.Length; i++)
      {
        blackDice[i] = blackDice[random.Next(blackDice.Length)];
      }
    }
  }
}
