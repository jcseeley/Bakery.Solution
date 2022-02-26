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
      Console.WriteLine("\nWELCOME TO PIERRE'S BAKERY!\n---------------------------");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("-Bread is $5 per loaf or Buy 2 Get 1 FREE!\n-Pastries are $2 each or 3 for $5!\n------------------------------------------");
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine("How many loaves of bread would you like?");
      int numberOfLoaves = int.Parse(Console.ReadLine());
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("------------------------------------\nAnd how many pastries for you today?");
      int numberOfPastries = int.Parse(Console.ReadLine());
      Bread userBread = new Bread(numberOfLoaves);
      Pastry userPastry = new Pastry(numberOfPastries);
      Console.ForegroundColor = ConsoleColor.Red;
      CalculatingOrder();
      int breadTotal = userBread.BreadPrice();
      int pastryTotal = userPastry.PastryPrice();
      int result = breadTotal + pastryTotal;
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nYOUR ORDER:\n--------------------\n" + userBread.NumberOfLoaves + " x Bread: $" + breadTotal + "\n" + userPastry.NumberOfPastries + " x Pastries: $" + pastryTotal + "\n--------------------" + "\nTotal: $" + result + "\n");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("----------------------------------------------------------------------\nWould you like to place another order? Type 'Y' for yes or 'N' for no.");
      string response = Console.ReadLine();
      if (response == "y" || response == "Y")
      {
        Main();
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("--------------------------------\nTHANK YOU FOR VISITING PIERRE'S!\n--------------------------------");
      }

      static void CalculatingOrder()
      {
        int counter = 0;
        for (int i = 0; i <= 44; i++)
        {
          switch (counter % 44)
          {
            case 0: Console.Write($"\rD"); break;
            case 1: Console.Write($"\rDE"); break;
            case 2: Console.Write($"\rDET"); break;
            case 3: Console.Write($"\rDETE"); break;
            case 4: Console.Write($"\rDETER"); break;
            case 5: Console.Write($"\rDETERM"); break;
            case 6: Console.Write($"\rDETERMI"); break;
            case 7: Console.Write($"\rDETERMIN"); break;
            case 8: Console.Write($"\rDETERMINI"); break;
            case 9: Console.Write($"\rDETERMININ"); break;
            case 10: Console.Write($"\rDETERMINING"); break;
            case 11: Console.Write($"\rDETERMINING "); break;
            case 12: Console.Write($"\rDETERMINING H"); break;
            case 13: Console.Write($"\rDETERMINING HO"); break;
            case 14: Console.Write($"\rDETERMINING HOW"); break;
            case 15: Console.Write($"\rDETERMINING HOW "); break;
            case 16: Console.Write($"\rDETERMINING HOW M"); break;
            case 17: Console.Write($"\rDETERMINING HOW MU"); break;
            case 18: Console.Write($"\rDETERMINING HOW MUC"); break;
            case 19: Console.Write($"\rDETERMINING HOW MUCH"); break;
            case 20: Console.Write($"\rDETERMINING HOW MUCH "); break;
            case 21: Console.Write($"\rDETERMINING HOW MUCH '"); break;
            case 22: Console.Write($"\rDETERMINING HOW MUCH 'D"); break;
            case 23: Console.Write($"\rDETERMINING HOW MUCH 'DO"); break;
            case 24: Console.Write($"\rDETERMINING HOW MUCH 'DOU"); break;
            case 25: Console.Write($"\rDETERMINING HOW MUCH 'DOUG"); break;
            case 26: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH"); break;
            case 27: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH'"); break;
            case 28: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' "); break;
            case 29: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' Y"); break;
            case 30: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YO"); break;
            case 31: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU"); break;
            case 32: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU "); break;
            case 33: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU O"); break;
            case 34: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU OW"); break;
            case 35: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU OWE"); break;
            case 36: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU OWE "); break;
            case 37: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU OWE H"); break;
            case 38: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU OWE HA"); break;
            case 39: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU OWE HA "); break;
            case 40: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU OWE HA H"); break;
            case 41: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU OWE HA HA"); break;
            case 42: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU OWE HA HA H"); break;
            case 43: Console.Write($"\rDETERMINING HOW MUCH 'DOUGH' YOU OWE HA HA HA"); break;
          }
          counter++;
          Thread.Sleep(125);
        }
        Console.Write($"\r                                                ");
      }
    }
  }
}