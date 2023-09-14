namespace AnagramNamespace.Models
  {
    public class Anagram
    {
      public string Word { get; set; }
      public string CompareWords { get; set; }

      public Anagram(string word, string compareWords)
      {
        Word = word;
        CompareWords = compareWords;
      }

      // public float CalculateArea()
      // {
      //   float area = _side1 * Side2;
      //   return area;
      // }
    }
  }