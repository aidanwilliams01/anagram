using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramNamespace.Models;

namespace AnagramTestNamespace.Tests
{
  [TestClass]
  public class AnagramTests
  {

    [TestMethod]
    public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
    {
      Anagram newAnagram = new Anagram("beard");
      Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      string word = "beard";
      Anagram newAnagram = new Anagram(word);
      string result = newAnagram.Word;
      Assert.AreEqual(word, result);
    }
  }
}