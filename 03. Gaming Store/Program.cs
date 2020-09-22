using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            double outFall4 = 39.99;
            double csGo = 15.99;
            double zplinterZell = 19.99;
            double honoredTwo = 59.99;
            double roverWatch = 29.99;
            double roverWatchOrEd = 39.99;

            double currentBalance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();

            double addGames = 0;
            double balance = currentBalance;
            double expansiveGame = 0;
            string gameName = string.Empty;


            while (game != "Game Time")
            {
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                switch (game)
                {
                    case "OutFall 4":
                        gameName = "OutFall 4";                        
                        expansiveGame = outFall4;
                        if (balance < expansiveGame)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {gameName}");
                        addGames += outFall4;
                        balance -= addGames;


                        break;

                    case "CS: OG":
                        gameName = "CS: OG";                        
                        expansiveGame = csGo;
                        if (balance < expansiveGame)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {gameName}");
                        addGames += csGo;
                        balance -= csGo;


                        break;

                    case "Zplinter Zell":
                        gameName = "Zplinter Zell";                       
                        expansiveGame = zplinterZell;
                        if (balance < expansiveGame)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {gameName}");
                        addGames += zplinterZell;
                        balance -= zplinterZell;


                        break;

                    case "Honored 2":
                        gameName = "Honored 2";                        
                        expansiveGame = honoredTwo;
                        if (balance < expansiveGame)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {gameName}");
                        addGames += honoredTwo;
                        balance -= honoredTwo;
                        break;

                    case "RoverWatch":
                        gameName = "RoverWatch";                      
                        expansiveGame = roverWatch;
                        if (balance < expansiveGame)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        Console.WriteLine($"Bought {gameName}");
                        addGames += roverWatch;
                        balance -= roverWatch;
                        break;

                    case "RoverWatch Origins Edition":
                        gameName = "RoverWatch Origins Edition";                
                        expansiveGame = roverWatchOrEd;
                        if (balance < expansiveGame)
                        {
                            Console.WriteLine("Too Expensive");
                            break;

                        }
                        Console.WriteLine($"Bought {gameName}");
                        addGames += roverWatchOrEd;
                        balance -= roverWatchOrEd;
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                

                game = Console.ReadLine();

            }
            double remaining = currentBalance - addGames;

            Console.WriteLine($"Total spent: ${addGames:f2}. Remaining: ${remaining:f2}");

        }
    }
}