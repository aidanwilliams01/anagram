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
      Anagram newAnagram = new Anagram();
      Assert.AreEqual(typeof(Anagram), newAnagram.GetType());
    }
  }
}