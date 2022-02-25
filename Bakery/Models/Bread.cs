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
      if (NumberOfLoaves <= 2)
      {
        return NumberOfLoaves * 5;
      }
      else if (NumberOfLoaves % 3 == 0)
      {
        return NumberOfLoaves / 3 * 10;
      }
      else if (NumberOfLoaves % 3 == 2)
      {
        return (NumberOfLoaves - 2) / 3 * 10 + 10;
      }
      else
      {
        return (NumberOfLoaves - 1) / 3 * 10 + 5;
      }
    }
  }
}