using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
  /*
      Devise a function that takes a string & returns the number of 
      vowels (aeiou) in that string.

      "Hi there!" = 3
      "What do you mean?"  = 6

      There are accompanying unit tests for this exercise, ensure all tests pass & make
      sure the unit tests are correct too.
   */
  public class VowelCount
  {
    public int Count(string value)
    {
      if (String.IsNullOrEmpty(value))
        throw new ArgumentException("Value Is Required");

      string resultString = value.ToLower();
      List<char> charsToRemove = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

      foreach (char c in charsToRemove)
      {
        resultString = resultString.Replace(c.ToString(), String.Empty);
      }

      return value.Length - resultString.Length;
    }
  }
}
