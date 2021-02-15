using System;
using System.Threading;

namespace csharp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Random num = new Random();
      int choiceNum = num.Next(3);
      string botChoice = "";
      if (choiceNum == 0)
      {
        botChoice = "rock";
      }
      else if (choiceNum == 1)
      {
        botChoice = "paper";
      }
      else if (choiceNum == 2)
      {
        botChoice = "scissors";
      }
      bool running = true;
      while (running)
      {
        Console.Clear();
        Console.WriteLine(@"
 .----------------.  .----------------.  .----------------. 
| .--------------. || .--------------. || .--------------. |
| |  _______     | || |   ______     | || |    _______   | |
| | |_   __ \    | || |  |_   __ \   | || |   /  ___  |  | |
| |   | |__) |   | || |    | |__) |  | || |  |  (__ \_|  | |
| |   |  __ /    | || |    |  ___/   | || |   '.___`-.   | |
| |  _| |  \ \_  | || |   _| |_      | || |  |`\____) |  | |
| | |____| |___| | || |  |_____|     | || |  |_______.'  | |
| |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------' 
      ");
        Console.WriteLine(@"
        
press 's' to start and 'q' anytime to quit"

        );
        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine();
        if (key.Key == ConsoleKey.S)
        {
          Console.WriteLine("rock paper or scissors?");
          string choice = Console.ReadLine();
          if (choice == "q")
          {
            running = false;
          }
          Console.WriteLine("You picked " + choice);
          Console.WriteLine("Bot picked " + botChoice);
          Thread.Sleep(1000);
          if (choice == "rock")
          {
            if (botChoice == "rock")
            {
              Console.WriteLine("Tie!");
              Thread.Sleep(1000);
              running = false;
            }
            else if (botChoice == "paper")
            {
              Console.WriteLine("You Lost");
              Thread.Sleep(1000);
              running = false;
            }
            else if (botChoice == "scissors")
            {
              Console.WriteLine("You Won!");
              Thread.Sleep(1000);
              running = false;
            }
          }
          else if (choice == "paper")
          {
            if (botChoice == "rock")
            {
              Console.WriteLine("You Won!");
              Thread.Sleep(1000);
              running = false;
            }
            else if (botChoice == "paper")
            {
              Console.WriteLine("Tie!");
              Thread.Sleep(1000);
              running = false;
            }
            else if (botChoice == "scissors")
            {
              Console.WriteLine("You Lost");
              Thread.Sleep(1000);
              running = false;
            }
          }
          else if (choice == "scissors")
          {
            if (botChoice == "rock")
            {
              Console.WriteLine("You Lost");
              Thread.Sleep(1000);
              running = false;
            }
            else if (botChoice == "paper")
            {
              Console.WriteLine("You Won!");
              Thread.Sleep(1000);
              running = false;
            }
            else if (botChoice == "scissors")
            {
              Console.WriteLine("Tie!");
              Thread.Sleep(1000);
              running = false;
            }
          }
          else
          {
            Console.WriteLine("invalid choice");
          }
        }
        else if (key.Key == ConsoleKey.Q)
        {
          running = false;
        }
        else
        {
          Console.WriteLine("invalid key");
        }
      }
    }
  }
}
