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
  }
}