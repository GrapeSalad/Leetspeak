using System;
using System.Collections.Generic;

namespace Leetspeak.Objects
{
  public class L33t
  {
    public char [] MakeLeet(string userInput)
    {
      char [] array = userInput.ToCharArray();

      for (int i=0; i<array.Length; i++)
      {
        if (array[i] == 'e')
        {
          array[i] = '3';
        }
        else if (array[i] == 'I')
        {
          array[i] = '1';
        }
        else if (array[i] == 'o')
        {
          array[i] = '0';
        }
        else if (array[i] == 't')
        {
          array[i] = '7';
        }
        else if ((array[i] == 's') && i != 0)
        {
          array[i] = 'z';
          Console.WriteLine("s");
        }
      }
      return array;
    }

    public string Convert(char [] array)
    {
      return string.Join("", array);
    }
  }
}
