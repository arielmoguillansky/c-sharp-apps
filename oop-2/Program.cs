// Polymorphism: the provision of a single interface to entities of different types.
// There is a generic concept of something(Ingredient), and this concept can be made concrete by multiple types (Cheddar, Mozzarella). All of them can be used wherever the generic concept is needed (in the Ingredients list).

// Inheritance: enables to create new classes that reuse, extend and modift the behavior defined in other classes.
// Base class: class whose members are inherited
// Derived class: class that inherits those members


Pizza pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());

Console.WriteLine(pizza.Describe());


public class Pizza
{
  private List<Ingredient> _ingredients = new List<Ingredient>(); // This is polymorphism: this list stores objects of different types. They have a common base type which is Ingredient type.
  public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

  public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient // Base class
{

}

public class Cheddar : Ingredient // Inheritance is an "is-a" relationship: Cheddar is an ingredient. Dog is an Animal class.
{
  public string Name => "Cheddar cheese";
  public int AgedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
  public string Name => "Tomato sauce";
  public int TomatoesIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
  public string Name => "Mozzarella";
  public bool IsLight { get; }
}
