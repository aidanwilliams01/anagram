using System;
using System.Collections.Generic;

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

      public string DetermineAnagram()
      {
        char[] wordArray = Word.ToCharArray();
        string[] compareWordsArray = CompareWords.Split(", ");
        string result = "";
        Array.Sort(wordArray);
        for (int index = 0; index < compareWordsArray.Length; index++)
        {
          char[] array = compareWordsArray[index].ToCharArray();
          Array.Sort(array);
          string word = String.Join(",", wordArray);
          string compareWord = String.Join(",", array);
          Console.WriteLine($"{word} {compareWord}");
          if (word == compareWord) // can't do this; convert to string?
          {
            result = result + compareWordsArray[index] + " ";
          }
        }
        result = result.Trim();
        return result;
      }
    }
  }