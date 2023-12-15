Console.WriteLine("Welcome to the calculator app!");
Console.WriteLine("Input the first number:");

int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");

int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Select the operation:");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubstract");
Console.WriteLine("[M]ultiply");
Console.WriteLine("[D]ivide");

string selectedOperation = Console.ReadLine().ToLower();

if (number2 == 0 && selectedOperation == "d")
{
  throw new Exception("Can't divide by zero");
}

if (selectedOperation == "a")
{
  PrintResult(Addition(number1, number2));
}
else if (selectedOperation == "s")
{
  PrintResult(Substraction(number1, number2));
}
else if (selectedOperation == "m")
{
  PrintResult(Multiplication(number1, number2));
}
else if (selectedOperation == "d")
{
  PrintResult(Division(number1, number2));
}
else
{
  Console.WriteLine("Invalid option");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

// Print method
void PrintResult(int result)
{
  Console.WriteLine("Result is: " + result);
}

// Arithmetic methods
int Addition(int a, int b)
{
  return a + b;
}

int Substraction(int a, int b)
{
  return a - b;
}

int Multiplication(int a, int b)
{
  return a * b;
}

int Division(int a, int b)
{
  return a / b;
}