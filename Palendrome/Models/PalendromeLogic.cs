using System;

namespace Palendrome
{
  public class PalendromeString
  {
    public static bool isPalendrome(string userInput) {
      for(int i = 0; i < (userInput.Length/2); i++) 
      {
        if (userInput[i] != userInput[userInput.Length - 1 -i])
        {
          return false;
        }
      }
      return true;
    }
  }
}