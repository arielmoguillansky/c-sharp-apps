Rectangle rectangle1 = new Rectangle(5, 10);
var calculator = new ShapesMeasurementsCalculator();

Console.WriteLine(rectangle1.Width);
Console.WriteLine(calculator.CalculateRectangleArea(rectangle1));
Console.ReadKey();


var medicalAppt = new MedicalAppointment("Ariel", new DateTime(2023, 4, 3));
medicalAppt.Reschedule(new DateTime(2023, 4, 4));


class Rectangle
{
  // public members (types, variables, methods) should start with capital letter
  //private members should start with underscore
  public int Width;
  public int Height;

  // constructor definition
  public Rectangle(int width, int height)
  {

    // Width = GetLength(width, "Width");
    Width = GetLength(width, nameof(Width));
    Height = GetLength(height, nameof(Height));
  }

  private int GetLength(int legnth, string name)
  {
    int defaultValue = 1;

    if (legnth <= 0)
    {
      Console.WriteLine($"{name} must be a positive number.");
      return defaultValue;
    }
    return legnth;
  }

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
    return 2 * rectangle.Width + 2 * rectangle.Height;
  }

  public int CalculateRectangleArea(Rectangle rectangle)
  {
    return rectangle.Width * rectangle.Height;
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