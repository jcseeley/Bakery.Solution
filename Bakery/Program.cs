using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!\nBread is $5 per loaf or Buy 2 Get 1 FREE!\nPastries are $2 each or 3 for $5!\nHow many loaves of bread would you like?");
      int numberOfLoaves = int.Parse(Console.ReadLine());
      Console.WriteLine("And how many pastries for you today?");
      int numberOfPastries = int.Parse(Console.ReadLine());
    }
  }
}