Random rnd = new Random();
Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

string input;
int inputNumber;
bool isInputNumber;

bool isValidNumber(string input)
{
  return true;
}

int generateNumber() => rnd.Next(1, 7);

do
{
  Console.WriteLine("Enter a number:");
  input = Console.ReadLine();
  isInputNumber = int.TryParse(input, out inputNumber);
  Console.WriteLine($"NUMBER {generateNumber()}");

}
while (!isInputNumber || inputNumber < 1 || inputNumber > 6);
Console.ReadKey();
