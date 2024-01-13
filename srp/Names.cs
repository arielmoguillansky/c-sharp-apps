class Names
{
  public List<string> GetNames { get; } = new List<string>();
  // private List<string> _names = new List<string>();
  private readonly NameValidator _nameValidator = new NameValidator();

  public void AddNames(List<string> stringsFromFile)
  {
    foreach (string name in stringsFromFile)
    {
      AddName(name);
    }
  }
  public void AddName(string name)
  {
    if (_nameValidator.IsValid(name))
    {
      GetNames.Add(name);
    }
  }
}