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
      if (NumberOfPastries <= 2)
      {
        return NumberOfPastries * 2;
      }
      else if (NumberOfPastries % 3 == 0)
      {
        return NumberOfPastries / 3 * 5; 
      }
      else if (NumberOfPastries % 3 == 2)
      {
        return (NumberOfPastries - 2) / 3 * 5 + 4;
      }
      else
      {
        return (NumberOfPastries - 1) / 3 * 5 + 2;
      }
    }
  }
}