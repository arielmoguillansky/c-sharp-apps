// namespaces contains a collection of classes. Think it as a box of lego bricks.Some bricks should be together to build a spaceship,others to build a house, and so on.
// namespaces should be named as their folder structure.
// One line scoped namespace declaration. Only available on C# v10.
namespace srp.DataAccess;
class StringTextualRepositories
{
  // not a const because it will evaluated in compilation time and Environment is for runtime. So turned into a static.
  private static readonly string Separator = Environment.NewLine;
  public List<string> Read(string filePath)
  {
    string fileVarContents = File.ReadAllText(filePath);
    return fileVarContents.Split(Separator).ToList();

  }

  public void Write(string filePath, List<string> strings)
  {
    File.WriteAllText(filePath, string.Join(Separator, strings));
  }
}

