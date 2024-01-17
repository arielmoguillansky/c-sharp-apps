using diceGame.Utils;
namespace diceGame.Game;
public class GuessingGame
{
  private readonly Dice _dice;
  private const int Tries = 3;
  private int _diceRollResult;

  public int GetDiceRollResult() => _diceRollResult;
  public GuessingGame(Dice dice)
  {
    _dice = dice;
  }

  public void PrintResult(GameResult gameResult)
  {
    string message = gameResult == GameResult.Victory
      ? message = "You Win!"
      : message = $"You loose!. The correct number was {GetDiceRollResult()}.";
    Console.WriteLine(message);
    Console.WriteLine("Press any key to exit");
  }

  public GameResult Play()
  {
    _diceRollResult = _dice.RollDice();
    Console.WriteLine($"Dice rolled. Guess what number it shows in {Tries} tries.");
    int triesLeft = Tries;
    while (triesLeft > 0)
    {
      int guess = ConsoleReader.ReadInteger("Enter a number:");

      if (guess == _diceRollResult)
      {
        return GameResult.Victory;
      }
      Console.WriteLine($"Incorrect. You have {triesLeft - 1} tries left.");
      triesLeft--;
    }
    return GameResult.Loss;
  }

}
