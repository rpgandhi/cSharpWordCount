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
    public void CountRepeats_CountInstancesofInputtedWordInInputtedSentence_One()
    {
      //Arrange
      string sentence = "The blue sky.";
      string word = "blue";
      RepeatCounter testSentence = new RepeatCounter(sentence, word);

      //Act
      int result = RepeatCounter.CountRepeats(sentence, word);

      //Assert
      Assert.AreEqual(1, result);
    }

    // [TestMethod]
    // public void CountRepeats_UserIsAbleToInputSentence_True()
    // {
    //   RepeatCounter testSentence = new RepeatCounter();
    //   string sentenceInput = testSentence.GetSentenceInput("hello");
    //   // RepeatCounter testRepeatCounter = new RepeatCounter();
    //   Console.WriteLine(sentenceInput);
    //   Assert.IsInstanceOfType(sentenceInput, typeof(string));
    // }

    // [TestMethod]
    // public void CountRepeats_UserIsAbleToInputSentence_True()
    // {
    //   RepeatCounter testRepeatCounter = new RepeatCounter();
    //   Assert.AreEqual(true, testRepeatCounter.CountRepeats(2));
    // }
  }
}
