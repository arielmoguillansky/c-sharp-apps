string artText = @".
 ______  _____   ____    _____                                   
/\__  _\/\  __`\/\  _`\ /\  __`\                                 
\/_/\ \/\ \ \/\ \ \ \/\ \ \ \/\ \         __     _____   _____   
   \ \ \ \ \ \ \ \ \ \ \ \ \ \ \ \      /'__`\  /\ '__`\/\ '__`\ 
    \ \ \ \ \ \_\ \ \ \_\ \ \ \_\ \    /\ \L\.\_\ \ \L\ \ \ \L\ \
     \ \_\ \ \_____\ \____/\ \_____\   \ \__/.\_\\ \ ,__/\ \ ,__/
      \/_/  \/_____/\/___/  \/_____/    \/__/\/_/ \ \ \/  \ \ \/ 
                                                   \ \_\   \ \_\ 
                                                    \/_/    \/_/ 
";
Console.WriteLine(artText);

string userInput;

// Arrays have size fixed
// int[] numbers = new int[3];
// int[] numbers = new int[] {1,2,3,4,5,6};
// int first_from_end = numbers[^1];
// int size = numbers.Length

// 2-d array
// char[,] letters = new char[2,3];
// char[0,0] = 'A';
// char[,] = new char[,] { {'A', 'B'}, {'C', 'D'} };
// int height = letters.GetLength(0);
// int width = letters.GetLength(1);
// dotnet publish project.csproj --configuration Release --runtime win-x64 - for generating a .exe file

Console.WriteLine("Hello!");
List<string> todos = new List<string>();

do
{
  Console.WriteLine();
  Console.WriteLine("What do you want to do?");
  Console.WriteLine("[S]ee all TODOs");
  Console.WriteLine("[A]dd a TODO");
  Console.WriteLine("[R]remove a TODO");
  Console.WriteLine("[E]xit");
  Console.WriteLine();

  userInput = Console.ReadLine().ToLower(); //capture user's input from console

  switch (userInput)
  {
    case "s":
      PrintSelectedOption("see all TODOs");
      SeeAllTodos();
      break;
    case "a":
      PrintSelectedOption("add TODO");
      AddTodo();
      break;
    case "r":
      PrintSelectedOption("remove TODO");
      RemoveTodo();
      break;
    case "e":
      Console.WriteLine("Bye!");
      break;
    default:
      Console.WriteLine("Invalid choice.");
      break;
  }
}
while (userInput[0] != 'e');

// Console.ReadKey(); //prevent window to close

void PrintSelectedOption(string selectedOption)
{
  Console.WriteLine("Selected option: " + selectedOption);
}

void SeeAllTodos()
{
  foreach (string todo in todos)
  {
    Console.WriteLine($"{todos.IndexOf(todo) + 1}. {todo}");
  }
}

void AddTodo()
{
  string todoDescription;
  do
  {
    Console.WriteLine("Enter the TODO description");
    todoDescription = Console.ReadLine();
    if (todoDescription.Length == 0)
    {
      Console.WriteLine("The description cannot be empty.");
    }
  }
  while (todoDescription.Length == 0);

  todos.Add(todoDescription);
}

void RemoveTodo()
{
  string todoIndex;
  bool isValidInput = false;
  do
  {
    Console.WriteLine("Enter number of TODO item to remove.");
    todoIndex = Console.ReadLine();
    bool isNum = int.TryParse(todoIndex, out int num);
    if (!isNum || num > todos.Count())
    {
      Console.WriteLine("Enter a valid number.");
    }
    else
    {
      isValidInput = true;
    }
  }
  while (!isValidInput);

  string confirm;
  string todoToRemove = todos.ElementAt(int.Parse(todoIndex) - 1);

  Console.BackgroundColor = ConsoleColor.Red;
  Console.ForegroundColor = ConsoleColor.White;
  Console.WriteLine($"Are you sure you want to remove {todoToRemove}? [Pres yes/y to continue]");
  Console.ResetColor();
  confirm = Console.ReadLine().ToLower();
  if (confirm == "y" || confirm == "yes")
  {
    Console.WriteLine("Successfully removed.");
    todos.RemoveAt(int.Parse(todoIndex) - 1);
  }

}

