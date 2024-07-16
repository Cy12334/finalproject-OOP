using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace blackjack
{
    internal class computation
    {
        const double initialMoney = 100;

        static string[] cardSymbol = { "CLUBS", "DIAMOND", "HEART", "CLOVER", };
        static string[] cardValue = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

        static List<int> playerCardScore = new List<int>();
        static List<int> dealerCardScore = new List<int>();

        static double playerMoney = initialMoney;

        static bool runningTheGame = true;

        static string name = "unnamed";
        static int age = 0;
        static string playerRole = "player";
        static string playerRank = "beginner";
        static int totalGamesPlayed = 0;
        static string playerIGN = "";

        static int currentWinningStreak = 0;
        static int bestWinningstreak = 0;


        static int playerTotalcards = 0;
        static int dealerTotalcards = 0;

        static int bettingAmount = 0;

        public static void InatialPlaerInformation()
        {


            Console.Write("Enter your username: ");
            name = Console.ReadLine();

            Console.Write("pls enter your ingame name: ");
            playerIGN = Console.ReadLine();

            Console.Write("enter your age: ");
            age = Convert.ToInt16(Console.ReadLine());

            newclass.SettPlayerSkillLevel(playerRank, bestWinningstreak, totalGamesPlayed);
            Console.Clear();
        }
         public  static int HitCard(string pullerRole = "player")
        {
            var randomGenerator = new Random();
            var cardSymbols = cardSymbol[randomGenerator.Next(cardSymbol.Length)];

            var playingCardIndex = randomGenerator.Next(cardSymbol.Length);
            var playingCards = cardValue[playingCardIndex];

            int cardScore = 0;
            if (playingCardIndex == 0)
            {
                cardScore = 11;
            }
            else if (playingCardIndex < 9)
            {
                cardScore = playingCardIndex + 1;
            }
            else
            {
                cardScore = 10;
            }



            if (pullerRole == "player")
            {
                playerCardScore.Add(cardScore);
                playerTotalcards += cardScore;
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                dealerCardScore.Add(cardScore);
                dealerTotalcards += cardScore;
                Console.ForegroundColor = ConsoleColor.Red;

            }
            Console.WriteLine($"{pullerRole} is drawing a card.... {playingCards} of {cardSymbols}");
            return cardScore;
        }
        public static void PrepareNewRound()
        {
            newclass.PrintNewGameMessage();

            playerTotalcards = 0;
            dealerTotalcards = 0;
            bettingAmount = 0;
        }

       public static void PrintTotalScore(string pullerRole = "player")
        {
            if (pullerRole == "player")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{pullerRole} total card score is: {playerTotalcards}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{pullerRole} total card is: {dealerTotalcards}");
            }


            Console.ForegroundColor = ConsoleColor.White;
        }

        public  static void CalculateRoundResult()
        {


            if (playerTotalcards > 21)
            {
                currentWinningStreak = 0;
                playerMoney -= bettingAmount;
                newclass.PlayerRoundLost(bettingAmount, playerMoney);
            }
            else if (dealerTotalcards > 21)
            {
                double wonAmount = bettingAmount * 2;
                currentWinningStreak++;
                if (bestWinningstreak < currentWinningStreak)
                {
                    bestWinningstreak = currentWinningStreak;
                }
                playerMoney += wonAmount;
                newclass.PlayerRoundWon(wonAmount, playerMoney);
            }
            else if (playerTotalcards > dealerTotalcards)
            {
                double wonAmount = bettingAmount * 2;
                currentWinningStreak++;
                if (bestWinningstreak < currentWinningStreak)
                {
                    bestWinningstreak = currentWinningStreak;
                }
                playerMoney += wonAmount;
                newclass.PlayerRoundWon(wonAmount, playerMoney);
            }
            else if (playerTotalcards == dealerTotalcards)
            {
                newclass.PlayerRoundDraw();
            }
            else
            {
                currentWinningStreak = 0;
                playerMoney -= bettingAmount;
                newclass.PlayerRoundLost(bettingAmount, playerMoney);
            }
        }
        public static bool IsBetValid()
        {
            bool isValid = false;
            if (bettingAmount <= playerMoney)
            {
                isValid = true;
            }

            return isValid;
        }
        public static void SetbetAmount()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PLACE YOUR BET PLEASE");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"YOUR TOTAL BALANCE IS {playerMoney}");
            bettingAmount = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
