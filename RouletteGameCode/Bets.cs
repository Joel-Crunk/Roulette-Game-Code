using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGameCode
{
    class Bets
    {
        Random random = new Random();
        public int[] rednum = new int[] { 1, 3, 5, 7, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        public int[] blacknum = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        public double money = new Money().Currency;
        public Bets()
        {
        }
        internal void Run()
        {

            money += 100;
            bool colorWinRed = false;
            bool continueGame = true;
           
            do
            {
                Console.WriteLine("Continue? Y or N");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.N)
                {
                    continueGame = false;
                }
                else
                {

          

                int deal = Deal();
                foreach (var item in rednum)
                {
                    if (deal == item)
                    {
                        colorWinRed = true;
                    }
                }


                //what type bet?
                Console.WriteLine("Choose \n1. colors \n2. numbers ");
                int betType = int.Parse(Console.ReadLine());

                int color = 0;



                if (betType == 1)
                {
                    Console.WriteLine("1. Red \n2. Black");
                    color = int.Parse(Console.ReadLine());


                }
                int bet = 39;
                if (betType == 2)
                {
                    Console.Write("Choose a number 1 - 35 ");
                    bet = int.Parse(Console.ReadLine());
                }


                int betAmount = BetAmount(ref money);

                //int deal = Deal();

                money = NumWin(money, bet, betAmount, deal);

                if (color == 1 && colorWinRed == true)
                {
                    Console.WriteLine("You win Red");
                    money += betAmount * 2;
                }
                if (color == 2 && colorWinRed == false)
                {
                    Console.WriteLine("You win Black");
                    money += betAmount * 2;
                }

                NewBalance(money);
                    }
            } while (continueGame == true);
            

        }

        internal void NewBalance(double money)
        {
            Console.WriteLine($" You have {money} dollars");
        }



        private int Deal()
        {
            int deal = random.Next(0, 38);
            Console.WriteLine(deal);
            return deal;
        }

        private static double NumWin(double money, int bet, int betAmount, int deal)
        {
            if (bet == deal)
            {
                Console.WriteLine("You Win!");
                money += betAmount * 35;
            }

            return money;
        }

        private static int BetAmount(ref double money)
        {
            Console.Write("How much do you want to bet? ");
            int betAmount = int.Parse(Console.ReadLine());
            money -= betAmount;
            return betAmount;
        }

    }
}
