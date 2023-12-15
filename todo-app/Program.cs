
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

// dotnet publish project.csproj --configuration Release --runtime win-x64 - for generating a .exe file
Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]remove a TODO");
Console.WriteLine("[E]xit");

string userInput = Console.ReadLine(); //capture user's input from console

if (userInput == "S")
{
  PrintSelectedOption("see all TODOs");
}
else if (userInput == "A")
{
  PrintSelectedOption("add TODO");
}
else if (userInput == "R")
{
  PrintSelectedOption("remove TODO");
}
else if (userInput == "E")
{
  PrintSelectedOption("exit");
}
else
{
  Console.WriteLine("No valid option selected");
}

Console.ReadKey(); //prevent window to close

void PrintSelectedOption(string selectedOption)
{
  Console.WriteLine("Selected option: " + selectedOption);
}

