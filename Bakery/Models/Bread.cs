using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int NumberOfLoaves { get; set; }
    public Bread(int numberOfLoaves)
    {
      NumberOfLoaves = numberOfLoaves;
    }

    public int BreadPrice()
    {
      if (NumberOfLoaves == 3)
      {
        return 10;
      }
      else
      {
        return NumberOfLoaves * 5;
      }
    }
  }
}