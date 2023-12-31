using System;
using AnagramNamespace.Models;
using System.Collections.Generic;

namespace AnagramNamespace
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Anagram app!");
      Console.WriteLine("Enter a word:");
      string string1 = Console.ReadLine();  
      Console.WriteLine("Enter a list of word(s) separated by a space:");
      string string2 = Console.ReadLine();
      Anagram newAnagram = new Anagram(string1, string2);
      string result = newAnagram.DetermineAnagram();
      if (result == "")
      {
        Console.WriteLine("There are no anagrams.");
      }
      else
      {
        Console.WriteLine($"List of anagrams of {string1}: {result}");
      }
      Console.WriteLine("Do you want to run the program again? (yes to run again, any other input to exit)");
      string string3 = Console.ReadLine();
      if (string3.ToLower() == "yes")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye");
      }
    }
  }
}