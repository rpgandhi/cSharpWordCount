using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCount.Models
{

  public class RepeatCounter
  {
    private string _sentence;
    private string _word;
    private int _counter;

    public RepeatCounter (string sentence, string word, int counter = 0)
    {
      _sentence = sentence;
      _word = word;
      _counter = counter;
    }

    public static int CountRepeats(string sentence, string word)
    {
      string [] phrase = sentence.Split(new Char [] {' ', ',', '.', ':', '/', '\t', ';', '?', '!', '#', });
      // string _sentence = sentence;
      // string _word = word;
      // string [] phrase = sentence.Split(new Char [] {' ', ',', '.', ':', '/', '\t', ';', '?', '!', '#', });
      int counter = 0;

      foreach (string currentWord in phrase)
      {
        if (currentWord == word)
        {
          counter++;
        }
      }

      // for (int i = 0; i <= sentence.Length; i++)
      // {
      //   if(phrase.Contains(word)== true)
      //   {
      //     counter ++;
      //   }
      // }
      return counter;
    }

    // public string RepeatCounter(string word, string sentence)
    // {
    //   string _word = word;
    //   string _sentence = sentence;
    //   int result = 0;
    //
    //   sentence = sentence.Trim();
    //   if (sentence == '')
    //   {
    //     return 0;
    //   }
    //   while (sentence.Contains(" "))
    //   {
    //     sentence = sentence.Replace(" ", " ");
    //   }
    //
    // }
    //
    // public string GetSentenceInput(string hello)
    // {
    //   string sentence = "hello";
    //   return sentence;
    //   // return _sentence;
    // }
    //
    // public void SetSentenceInput(string newSentence)
    // {
    //   _sentence = newSentence;
    //
    // }
    //
    // public static string GetWordInput()
    // {
    //   return _word;
    // }
    //
    // public void SetWordInput(string newWord)
    // {
    //   _word = newWord;
    // }
    //
    // public static string CountRepeats(string input, string word)
    // {
    //
    //   return false;
    // }

  }
}
