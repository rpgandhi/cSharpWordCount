using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount.Models;

namespace WordCount.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountRepeats_UserIsAbleToInputWords_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.AreEqual(true, testRepeatCounter.CountRepeats(2));
    }
  }
}
