global using System.Diagnostics;
using srp.DataAccess;

Stopwatch stopwatch = Stopwatch.StartNew();
for (int i = 0; i < 100; i++)
{
  Console.WriteLine($"Number {i}");
}

stopwatch.Stop();
Console.WriteLine($"Time in ms: {stopwatch.ElapsedMilliseconds}");

Names names = new Names();
string path = new NameFilePathBuilder().BuildFilePath();
var stringsTextualRepository = new StringTextualRepositories();
if (File.Exists(path))
{
  Console.WriteLine("Names file already exists. Loading names.");
  var stringsFromFile = stringsTextualRepository.Read(path);
  names.AddNames(stringsFromFile);
}
else
{
  Console.WriteLine("Names file does not exist yet.");

  names.AddName("John");
  names.AddName("not a valid name");
  names.AddName("Claire");
  names.AddName("123 not valid");

  Console.WriteLine("Saving names to a file");
  stringsTextualRepository.Write(path, names.GetNames);
}

Console.WriteLine(new NameFormatter().Format(names.GetNames));
Console.ReadKey();
// SOLID
// Single Responsibility Principle: class should be responsible for only one thing & should have one reason to change
// The following code does not follow the SRP.
/*

class Names
{
  private List<string> _names = new List<string>();

  public void AddName(string name)
  {
    if (IsValidName(name))
    {
      _names.Add(name);
    }
  }

  private bool IsValidName(string name)
  {
    return name.Length >= 2 && name.Length < 25 && char.IsUpper(name[0]) && name.All(char.IsLetter);
  }

  public void ReadFromFile()
  {
    string fileVarContents = File.ReadAllText(BuildFilePath());
    List<string> namesFromFile = fileVarContents.Split(Environment.NewLine).ToList();
    foreach (string name in namesFromFile)
    {
      AddName(name);
    }
  }

  public void WriteToTextFile()
  {
    File.WriteAllText(BuildFilePath(), Format());
  }

  public string BuildFilePath()
  {
    return "names.txt";
  }

  public string Format()
  {
    return string.Join(Environment.NewLine, _names);
  }
}
*/
