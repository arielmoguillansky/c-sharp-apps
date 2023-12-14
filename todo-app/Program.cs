
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
  Console.WriteLine("Selected option see all");
}
else if (userInput == "A")
{
  Console.WriteLine("Selected option add");
}
else if (userInput == "R")
{
  Console.WriteLine("Selected option remove");
}
else if (userInput == "E")
{
  Console.WriteLine("Selected option exit");
}
else
{
  Console.WriteLine("No valid option selected");
}

Console.ReadKey(); //prevent window to close