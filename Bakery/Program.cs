using Bakery.Models;
using System;

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
      Bread userBread = new Bread(numberOfLoaves);
      Pastry userPastry = new Pastry(numberOfPastries);
      int result = userBread.BreadPrice() + userPastry.PastryPrice();
      Console.WriteLine("\nThe total for your order is $" + result + ".\n\nWould you like to place another order?\nType 'Y' for yes or 'N' for no.");
      string response = Console.ReadLine();
      if (response == "y" || response == "Y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Thank you for visiting Pierre's!");
      }
    }
  }
}