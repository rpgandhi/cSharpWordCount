using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount.Models;

namespace WordCount.Tests
{
  [TestClass]
  public class WordCountTest
  {
    [TestMethod]
    public void Method_Description_ExpectedValue()
    {
      Assert.AreEqual(var1, method(input));
    }
  }
}
