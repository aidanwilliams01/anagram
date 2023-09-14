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
      Anagram newAnagram = new Anagram("beard", "bread, test");
      Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      string word = "beard";
      Anagram newAnagram = new Anagram(word, "bread, test");
      string result = newAnagram.Word;
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void SetWord_SetsValueOfWord_Void()
    {
      Anagram newAnagram = new Anagram("beard", "bread, test");
      string newWord = "bear";
      newAnagram.Word = newWord;
      Assert.AreEqual(newWord, newAnagram.Word);
    }

    [TestMethod]
    public void GetCompareWords_ReturnCompareWords_String()
    {
      string compareWords = "bread, test";
      Anagram newAnagram = new Anagram("beard", compareWords);
      string result = newAnagram.CompareWords;
      Assert.AreEqual(compareWords, result);
    }
  }
}