// dotnet publish project.csproj --configuration Release --runtime win-x64 - for generating a .exe file
Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]remove a TODO");
Console.WriteLine("[E]xit");

string userInput = "A";

Console.WriteLine(userInput);

Console.ReadKey();