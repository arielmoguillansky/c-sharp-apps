namespace diceGame.Game;
public class Dice
{
  private readonly Random _diceNumber;
  private int _numberOfSides;
  public Dice(Random diceNumber, int numberOfSides = 6)
  {
    _diceNumber = diceNumber;
    _numberOfSides = numberOfSides;
  }

  public int GetNumberOfSides() => _numberOfSides;
  public void SetNumberOfSides(int sides)
  {
    if (sides != 8 && sides != 10 && sides != 12 && sides != 20)
    {
      Console.WriteLine("Incorrect number of sides for a dice.");
    }
    else
    {
      _numberOfSides = sides;
    }
  }

  public int RollDice() => new Random().Next(1, GetNumberOfSides() + 1);

  public void Describe() => Console.WriteLine($"This is a dice with {GetNumberOfSides()} sides");

}