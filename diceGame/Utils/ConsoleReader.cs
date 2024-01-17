namespace diceGame.Utils;
public static class ConsoleReader
{
  public static int ReadInteger(string msg)
  {
    int result;
    do
    {
      Console.WriteLine(msg);
    } while (!int.TryParse(Console.ReadLine(), out result));
    return result;
  }
}
