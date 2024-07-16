using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class combinedclass
    {
        public static void HandelNewRound(double playerMoney, int bettingAmount, bool runningTheGame)
        {
            computation.PrepareNewRound();
            computation.SetbetAmount();
            if (!computation.IsBetValid())
            {
                newclass.PrintInvalidMessage();
                runningTheGame = false;
                return;
            }

            var firstCardTotal = computation.HitCard();
            var secondCardTotal = computation.HitCard();
            var thirdCardScore = 0;

            var firstDealerCard = computation.HitCard("dealer");
            var secondDealerCard = computation.HitCard("dealer");



            Console.WriteLine("1. HIT OR 2. STAND");
            var shoulDeal = Console.ReadLine();

            if (shoulDeal == "1")
            {
                thirdCardScore = computation.HitCard();

            }
            computation.PrintTotalScore();
            computation.PrintTotalScore("Dealer ");
            computation.CalculateRoundResult();
        }
    }
}
