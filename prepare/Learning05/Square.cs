public class Square : Shape
{
  private double _side;
  public Square(string color, double side) : base(color)
  {
    _side = side;
  }

  public override double GetArea()
  {
    return Math.Pow(_side, 2);
  }
}