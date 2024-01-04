
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

do
{
  // dotnet publish project.csproj --configuration Release --runtime win-x64 - for generating a .exe file
  Console.WriteLine("Hello!");
  Console.WriteLine("What do you want to do?");
  Console.WriteLine("[S]ee all TODOs");
  Console.WriteLine("[A]dd a TODO");
  Console.WriteLine("[R]remove a TODO");
  Console.WriteLine("[E]xit");

  userInput = Console.ReadLine().ToLower(); //capture user's input from console

  switch (userInput)
  {
    case "s":
      PrintSelectedOption("see all TODOs");
      break;
    case "a":
      PrintSelectedOption("add TODO");
      break;
    case "r":
      PrintSelectedOption("remove TODO");
      break;
    case "e":
      PrintSelectedOption("exit");
      break;
    default:
      Console.WriteLine("No valid option selected");
      break;
  }
}
while (userInput[0] != 'e');

Console.ReadKey(); //prevent window to close

void PrintSelectedOption(string selectedOption)
{
  Console.WriteLine("Selected option: " + selectedOption);
}

