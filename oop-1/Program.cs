Rectangle rectangle1 = new Rectangle(5, 10);
var calculator = new ShapesMeasurementsCalculator();

Console.WriteLine(Rectangle.DescribeGeneral());
Console.WriteLine(rectangle1.Width);
Console.WriteLine(rectangle1.GetHeight());
Console.WriteLine(calculator.CalculateRectangleArea(rectangle1));
rectangle1.Width = 12;
Console.ReadKey();


var medicalAppt = new MedicalAppointment("Ariel", new DateTime(2023, 4, 3));
medicalAppt.Reschedule(new DateTime(2023, 4, 4));

Console.WriteLine(Calculator.Add(1, 2));


// Stateless class. Has no state.
// When all methods are static, class becomes a static class.
// Static class cannot be instantiated, only works as a container for methods.
static class Calculator
{

  // static methods belong to a class as a whole, not to a specific instance. Meaning, it is not necessary to create different instances of a class.
  // Static methods cannot use data.
  public static int Add(int a, int b) => a + b;
  public static int Multiply(int a, int b) => a * b;
}

// Rectangle is a stateful class
class Rectangle
{
  // public members (types, variables, fields, methods) should start with capital letter
  //private members should start with underscore
  // readonly prevents fields to be modified
  // public readonly int Width;
  // private int _height;

  public static int NumberOfInstances { get; private set; }

  // constructor definition
  public Rectangle(int width, int height)
  {

    // Width = GetLength(width, "Width");
    Width = GetLength(width, nameof(Width));
    Height = GetLength(height, nameof(Height));
    ++NumberOfInstances; // if was not static, it will reset the counter to one every time an instance is created.
  }

  private int GetLength(int length, string name)
  {
    // constants must be initialized. Used for constant values known at compilation time. Const are implicitly static.
    const int DefaultValue = 1;

    if (length <= 0)
    {
      Console.WriteLine($"{name} must be a positive number.");
      return DefaultValue;
    }
    return length;
  }


  // These are called fields. Backing fields.
  // private int _width;
  // private int _height;

  // // This is a property. Long syntax definition
  // public int Width
  // {
  //   get
  //   {
  //     return _width;
  //   }
  //   set
  //   {
  //     if (value > 0)
  //     {
  //       _width = value;
  //     }
  //   }
  // }

  // Shorter version of property declaration.
  public int Width { get; set; }
  public int Height { get; set; }

  public int GetHeight() => Height;
  public void SetHeight(int value)
  {
    if (value > 0)
    {
      Height = value;
    }
  }

  // Computed property
  public string Description => $"Rectangle width: {Width}, and height: {Height}";

  public static string DescribeGeneral() => "A shape";

  // methods should start with a verb
  // encapsulation example: methods and data under the same class.
  // private int CalculateCircumference()
  // {
  //   return 2 * Width + 2 * Height;
  // }

  // public int CalculateArea()
  // {
  //   return Width * Height;
  // }

}

class ShapesMeasurementsCalculator
{
  // methods should start with a verb
  public int CalculateRectangleCircumference(Rectangle rectangle)
  {
    return 2 * rectangle.Width + 2 * rectangle.GetHeight();
  }

  public int CalculateRectangleArea(Rectangle rectangle)
  {
    return rectangle.Width * rectangle.GetHeight();
  }
}

class MedicalAppointmentPrinter
{
  public void Print(MedicalAppointment medicalAppointment)
  {
    Console.WriteLine($"Appointment date: {medicalAppointment.GetDate()}");
  }

}

class MedicalAppointment
{
  private string _patientName;
  private DateTime _date;

  public MedicalAppointment(string patientName, DateTime date)
  {
    _patientName = patientName;
    _date = date;
  }

  // Constructors overloading. Must be distinguishable by parameters to work. 
  // Constructor useless since we use a default value in the constructor below
  // public MedicalAppointment(string patientName) : this(patientName, 7)
  // {
  //   // Use this to call other constructor to avoid repetition
  //   // _patientName = patientName;
  //   // _date = DateTime.Now.AddDays(7);
  // }

  // Optional values must be compile-valid types (string, bools, int, etc), and must be placed after all non optional parameters.
  public MedicalAppointment(string patientName, int daysFromNow = 7)
  {
    _patientName = patientName;
    _date = DateTime.Now.AddDays(daysFromNow);
  }

  public void Reschedule(DateTime date)
  {
    _date = date;
    var printer = new MedicalAppointmentPrinter();
    printer.Print(this);
  }

  // Method overloading: multiple methods with the same name. They must to be distinguishable by parameters to work. Avoid this, rename methods.
  public void Reschedule(int month, int day)
  {
    _date = new DateTime(_date.Year, month, day);
  }

  // getter: usefull to read variables that are private.
  // expression-bodied methods: valid when only has one single expression
  public DateTime GetDate() => _date;
}