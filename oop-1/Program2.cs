
// object initializer when class has no constructor. All properties are optional.
var person = new Person
{
  Name = "John",
  YearOfBirth = 1992
};
class Person
{
  public string Name { get; set; }

  // the init parameter mean that you can set the property once only in object initialization.
  public int YearOfBirth { get; init; }

  // public Person(string name, int year)
  // {
  //   Name = name;
  //   YearOfBirth = year;
  // }
}