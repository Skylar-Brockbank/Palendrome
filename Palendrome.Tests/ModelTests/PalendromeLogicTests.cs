using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palendrome;

namespace Palendrome.Tests
{
  [TestClass]
  public class PalendromeTests
  {
    [TestMethod]
    public void IsPalendrome_ActuallyAPalendrome_True()
    {
      Assert.AreEqual(true, PalendromeString.isPalendrome("racecar"));
    }
    [TestMethod]
    public void IsPalendrome_ActuallyAPalendrome_False()
    {
      Assert.AreEqual(false, PalendromeString.isPalendrome("racistcar"));
    }
  }
}