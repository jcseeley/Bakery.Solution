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
        for (int i = 0; i <= 25; i++)
        {
          switch (counter % 23)
          {
            case 0: Console.Write($"\r"); break;
            case 1: Console.Write($"\rC"); break;
            case 2: Console.Write($"\rCA"); break;
            case 3: Console.Write($"\rCAL"); break;
            case 4: Console.Write($"\rCALC"); break;
            case 5: Console.Write($"\rCALCU"); break;
            case 6: Console.Write($"\rCALCUL"); break;
            case 7: Console.Write($"\rCALCULA"); break;
            case 8: Console.Write($"\rCALCULAT"); break;
            case 9: Console.Write($"\rCALCULATI"); break;
            case 10: Console.Write($"\rCALCULATIN"); break;
            case 11: Console.Write($"\rCALCULATING"); break;
            case 12: Console.Write($"\rCALCULATIN"); break;
            case 13: Console.Write($"\rCALCULATI"); break;
            case 14: Console.Write($"\rCALCULAT"); break;
            case 15: Console.Write($"\rCALCULA"); break;
            case 16: Console.Write($"\rCALCUL"); break;
            case 17: Console.Write($"\rCALCU"); break;
            case 18: Console.Write($"\rCALC"); break;
            case 19: Console.Write($"\rCAL"); break;
            case 20: Console.Write($"\rCA"); break;
            case 21: Console.Write($"\rC"); break;
            case 22: Console.Write($"\r"); break;
          }
          counter++;
          Thread.Sleep(75);
        }
        Console.Write($"\r               ");
      }
    }
  }
}