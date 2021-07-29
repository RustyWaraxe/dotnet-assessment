using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
  public class Anagram
  {
    public bool AreAnagrams(string word1, string word2)
    {
      if (String.IsNullOrEmpty(word1))
        throw new ArgumentException("word 1 needed");

      if (String.IsNullOrEmpty(word2))
        throw new ArgumentException("word 2 needed");

      word1 = Regex.Replace(word1, "[?!., _]", "").ToLower();
      word2 = Regex.Replace(word2, "[?!., _]", "").ToLower();

      if (word1.Length != word2.Length) return false;

      List<char> list1 = new List<char>();
      list1.AddRange(word1);

      List<char> list2 = new List<char>();
      list2.AddRange(word2);

      foreach (char currentLetter in list1)
      {
        if (!list2.Remove(currentLetter)) return false;
      }

      if (list2.Count == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
