namespace AnagramNamespace.Models
  {
    public class Anagram
    {
      public string Word { get; set; }

      public Anagram(string word)
      {
        Word = word;
      }

      // public float CalculateArea()
      // {
      //   float area = _side1 * Side2;
      //   return area;
      // }
    }
  }