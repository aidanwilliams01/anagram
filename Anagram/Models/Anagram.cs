namespace ShapeTracker.Models
  {
    public class Rectangle
    {
      public int Side2 { get; set; }

      public Rectangle(int length1, int length2)
      {
        _side1 = length1;
        Side2 = length2;
      }

      public float CalculateArea()
      {
        float area = _side1 * Side2;
        return area;
      }
    }
  }