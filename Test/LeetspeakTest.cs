using Xunit;
using System;
using System.Collections.Generic;
using Leetspeak.Objects;

namespace Leetspeak
{
  public class LeetspeakTest
  {
    // [Fact]
    // public void CheckArray()
    // {
    //   char [] array = new char [] {'a', 'b', 'c'};
    //   char [] strArray = "abc".ToCharArray();
    //   Assert.Equal(array, strArray);
    // }
    [Fact]
    public void CheckForLeet()
    {
      char [] arrayTest = new char [] {'S', '7', 'r', 'i', 'n', 'g', '3', '1', 'z'};
      L33t instance = new L33t();
      Assert.Equal(arrayTest, instance.MakeLeet("StringeLs"));
    }
  }
}
