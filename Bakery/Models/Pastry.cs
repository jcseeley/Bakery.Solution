using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int NumberOfPastries { get; set; }
    public Pastry(int numberOfPastries)
    {
      NumberOfPastries = numberOfPastries;
    }

    public int PastryPrice()
    {
      if (NumberOfPastries == 3)
      {
        return 5;
      }
      else
      {
        return NumberOfPastries * 2;
      }
    }
  }
}