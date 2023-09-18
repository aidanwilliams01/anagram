using System;
using AnagramNamespace.Models;
using System.Collections.Generic;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Anagram newAnagram = new Anagram("beard", "beard, bread, test");
      string result = newAnagram.DetermineAnagram();
      Console.WriteLine($"{result}");
      // Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      // Console.WriteLine("Welcome to the Shape Tracker app!");
      // Console.WriteLine("Type 'triangle' to check the type of a triangle, 'rectangle' to calculate the area of a rectangle, or any key to exit.");
      // string userResponse = Console.ReadLine();
      // try
      // {
      //   if (userResponse == "triangle" || userResponse == "Triangle")
      //   {
      //     Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
      //     Console.WriteLine("Please enter a number:");
      //     string stringNumber1 = Console.ReadLine();  
      //     Console.WriteLine("Enter another number:");
      //     string stringNumber2 = Console.ReadLine();  
      //     Console.WriteLine("Enter a third number:");
      //     string stringNumber3 = Console.ReadLine();  
      //     int length1 = int.Parse(stringNumber1);  
      //     int length2 = int.Parse(stringNumber2);  
      //     int length3 = int.Parse(stringNumber3);  
      //     // Triangle tri = new Triangle(length1, length2, length3);
      //     ConfirmOrEditTriangle(tri);
      //   }
      //   else if (userResponse == "rectangle" || userResponse == "Rectangle")
      //   {
      //     Console.WriteLine("We'll calculate the area of your rectangle by multiplying the lengths of two sides.");
      //     Console.WriteLine("Please enter a number:");
      //     string stringNumber1 = Console.ReadLine();  
      //     Console.WriteLine("Enter another number:");
      //     string stringNumber2 = Console.ReadLine(); 
      //     int length1 = int.Parse(stringNumber1);  
      //     int length2 = int.Parse(stringNumber2);  
      //     // Rectangle rec = new Rectangle(length1, length2);
      //     CalculateRectangleArea(rec);
      //   }
      //   else
      //   {
      //     Console.WriteLine("Goodbye!");
      //   }
      // }
      // catch
      // {
      //     Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
      //     Console.WriteLine("ERROR: Please only enter in numbers! Special symbols and alphabetic characters will not be accepted.");
      //     Console.WriteLine("Please try again...");
      //     Main();
      // }
    }
  }
}