using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace blackjack
{

     public class newclass
    {
        


        public static void Thelogo()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("  ██████╗ ██╗      █████╗  ██████╗██╗  ██╗         ██████╗  █████╗  ██████╗██╗  ██╗");
            Console.WriteLine(" ██    ██ ██║     ██╔══██╗██╔════╝██║ ██╔╝        ██╔════╝ ██╔══██╗██╔════╝██║ ██╔╝");
            Console.WriteLine(" ████████ ██║     ██╗  ██╗        █████╔╝         ██║  ███╗███████║██║     █████╔╝ ");
            Console.WriteLine(" ██║   ██║██║     ██╔══██║██║     ██╔═██╗         ██║   ██║██╔══██║██║     ██╔═██╗ ");
            Console.WriteLine(" ╚██████╔╝███████╗██║  ██║╚██████╗██║  ██╗        ██████╔╝██║  ██║╚██████╗██║  ██╗");
            Console.WriteLine("  ╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝        ╚═════╝ ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝");

        }
        public static void PlayerMenu()
        {
            Console.WriteLine("1. TO ENTER THE GAME ");
            Console.WriteLine("2. RESET STATS ");
            Console.WriteLine("3. STATS ");
            Console.WriteLine("4. CREDITS ");
            Console.WriteLine("5. EXIT ");
        }
        public static void Printoption()
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("CREATOR OF THE GAME CYRON POGI");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("PRESS ANY KEY TO GO BACK");
            Console.ReadKey();
        }

        public static void playerInfo(string playerRole, string playerRank, string playerIGN, int currentWinningStreak, int bestWinningstreak, string name, int age, double playerMoney)
        {
            
            Console.ResetColor();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine($"|  {playerRole}  |  |  {playerRank}  |  |  {playerIGN}  |  |  {name}  {age}  |");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine($"| CURRENT WINNING STREAK {currentWinningStreak} (+{currentWinningStreak * 2})% BONUS | BEST WINNNG STREAK {bestWinningstreak} |");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine($"hello  {playerIGN}");
            Console.WriteLine($"your total money:  {playerMoney}");
        }
         public static void PrintStats( string playerRank, string playerIGN, int currentWinningStreak, int bestWinningstreak, string name, int age, int totalGamesPlayed)
        {
            Console.WriteLine($"YOUR USENAME {name}");
            Console.WriteLine($"YOUR IGN {playerIGN}");
            Console.WriteLine($"YOUR AGE {age}");
            Console.WriteLine($"YOUR RANK {playerRank}");
            Console.WriteLine($"YOUR GAMESPLAYED {totalGamesPlayed}");
            Console.WriteLine($"CURRENT WIN STREAK {currentWinningStreak}");
            Console.WriteLine($"BEST WIN STREAK {bestWinningstreak}");

        }
         public static void resetPlayerStats(string playerRank, int currentWinningStreak, int bestWinningstreak,   int totalGamesPlayed, double playerMoney, double initialMoney)
        {
            totalGamesPlayed = 0;
            currentWinningStreak = 0;
            bestWinningstreak = 0;
            playerMoney = initialMoney;
            playerRank = "beginner";
            Console.WriteLine("STATS WERE RESET");
            Console.WriteLine("PRESS ANY KEY TO GO BACK");
            Console.ReadKey();

        }
      public  static void SettPlayerSkillLevel(string playerRank,   int bestWinningstreak,  int totalGamesPlayed)
        {
            Console.WriteLine("enter how many games you played:");
            totalGamesPlayed = Convert.ToInt16(Console.ReadLine());

            if (totalGamesPlayed < 50)
            {
                playerRank = "beginner";
            }
            else if (totalGamesPlayed < 100)
            {
                playerRank = "saktohan";
            }
            else if (totalGamesPlayed < 150)
            {
                playerRank = "malakasan";
            }
            else
            {
                playerRank = "BATAK";
            }
        }
        public static void PrintNewGameMessage()
        {
            Console.WriteLine("SHUFFLING......");
            Console.WriteLine("DONE");
            Console.WriteLine("DISTRIBUTING...");
        }

       public static void PlayerRoundDraw()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("YOU WON NOTHING ITS A TIE");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
        public static void PlayerRoundLost(int bettingAmount, double playerMoney)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($" DEALER WON YOU LOST {bettingAmount}!! \n\n YOUR CRURRENT MONEY: {playerMoney}\n\nPRESS ANY KEY TO EXIT ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
        public static void PlayerRoundWon(double wonAmount, double playerMoney)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"CONGRATIOLATIONS!! YOU WON A {wonAmount}!!\n\nYOUR CURRENT MONEY:{playerMoney}\n\nPRESS ANY KEY TO EXIT");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
       
        public static void PrintInvalidMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("INSUFFICIENT FUNDS!!!!");
            Console.WriteLine("PRESS ANY KEY TO QUIT");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

    }
}
