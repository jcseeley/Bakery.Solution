using Bakery.Models;
using System;
using System.Threading;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("Welcome to Pierre's Bakery!\n");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("-Bread is $5 per loaf or Buy 2 Get 1 FREE!\n-Pastries are $2 each or 3 for $5!\n");
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine("How many loaves of bread would you like?");
      int numberOfLoaves = int.Parse(Console.ReadLine());
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("And how many pastries for you today?");
      int numberOfPastries = int.Parse(Console.ReadLine());
      Bread userBread = new Bread(numberOfLoaves);
      Pastry userPastry = new Pastry(numberOfPastries);
      CalculatingOrder();
      int result = userBread.BreadPrice() + userPastry.PastryPrice();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nThe total for your order is $" + result + ".\n");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Would you like to place another order? Type 'Y' for yes or 'N' for no.");
      string response = Console.ReadLine();
      if (response == "y" || response == "Y")
      {
        Main();
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Thank you for visiting Pierre's!\n");
      }

      static void CalculatingOrder()
      {
        int counter = 0;
        for (int i = 0; i <= 30; i++)
        {
          switch (counter % 12)
          {
            case 0: Console.Write($"\rCal"); break;
            case 1: Console.Write($"\r   cu"); break;
            case 2: Console.Write($"\r     la"); break;
            case 3: Console.Write($"\r       ting"); break;
            case 4: Console.Write($"\rCalculating"); break;
            case 5: Console.Write($"\r           "); break;
            case 6: Console.Write($"\rCalculating ."); break;
            case 7: Console.Write($"\r             "); break;
            case 8: Console.Write($"\rCalculating . ."); break;
            case 9: Console.Write($"\r               "); break;
            case 10: Console.Write($"\rCalculating . . . "); break;
            case 11: Console.Write($"\r                  "); break;
          }
          counter++;
          Thread.Sleep(100);
        }
        Console.Write($"\r               ");
      }
    }
  }
}