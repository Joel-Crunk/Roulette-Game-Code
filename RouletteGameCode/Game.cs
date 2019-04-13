using System;

namespace RouletteGameCode
{
    internal class Game
    {
       
     public Game()
        {
        }

        internal void Run()
        {
            new GameTitle();
           

            
            
            new Bets().Run();
           // bool continueGame = true;
            // Console.WriteLine("Continue? Y or N");
            //ConsoleKey key = Console.ReadKey(true).Key;
            //do
            //    {
            //        if (key == ConsoleKey.N)
            //        {
            //            continueGame = false;
            //        }
            //        else
            //        {

            //        }
            //    } while (continueGame == true);

            Console.WriteLine("Good bye");
            

        }

    }
}