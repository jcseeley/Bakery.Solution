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
      return 1;
    }
  }
}