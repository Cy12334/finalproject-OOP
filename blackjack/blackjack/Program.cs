using blackjack;
using System.ComponentModel.Design;
using System.Security.Cryptography;

internal class Program
{
    const double initialMoney = 100;

    static string[] cardSymbol = { "CLUBS", "DIAMOND", "HEART", "CLOVER", };
    static string[] cardValue = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

    static List <int> playerCardScore = new List <int>();
    static List <int> dealerCardScore = new List <int>();

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
    
    private static void Main(string[] args)
    {



        computation.InatialPlaerInformation();

        if (playerIGN == "")
        {
            playerIGN = "unnamed";
        }
        while (runningTheGame)
        {
            newclass.Thelogo();

            newclass.playerInfo( playerRole,  playerRank,  playerIGN,  currentWinningStreak,  bestWinningstreak,  name,  age,  playerMoney);

            newclass.PlayerMenu();
           
            Console.WriteLine("\n PLEASE SELECT");
            string selectedOptionMenu = Console.ReadLine();

            switch (selectedOptionMenu)
            {

                case "1":
                    combinedclass.HandelNewRound( playerMoney,  bettingAmount,  runningTheGame);

                    break;

                case "2":
                    Console.WriteLine("ARE YOOU SURE YOU WANT TO RESET STATS? \n 1. yes \n 2. no");
                    string answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        newclass.resetPlayerStats(playerRank, currentWinningStreak, bestWinningstreak, totalGamesPlayed, playerMoney, initialMoney);

                    }

                    break;

                case "3":
                    newclass.PrintStats(playerRank, playerIGN, currentWinningStreak, bestWinningstreak, name, age, totalGamesPlayed);

                    break;

                case "4":
                    newclass.Printoption();

                    break;

                case "5":
                    Console.WriteLine("EXITING THE GAME.....");
                    runningTheGame = false;

                    break;
            }
            Console.Clear();
        }
    }


    
}


