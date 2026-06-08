using System;
using System.Collections.Generic;

namespace Mesozoicos
{
    public static class BotStrategy
    {
        public static string[] EscolherJogada(
            List<string[]> hand,
            List<string[]> myBoard,
            List<string[]> opponentBoard,
            List<string> myValidEnclosures,
            List<string> opponentValidEnclosures,
            List<string[]> allDinos,
            int turn)
        {
            double bestValue = double.MinValue;
            string bestDino = null, bestCercado = null;

            foreach (var dinoEntry in hand)
            {
                string dinoCode = dinoEntry[0];

                foreach (string cercado in myValidEnclosures)
                {
                    double myGain = BotScoring.MarginalScore(dinoCode, cercado, myBoard, opponentBoard, allDinos, turn);
                    if (myGain == double.MinValue) continue;

                    double opGain = BestOpponentGain(hand, dinoCode, opponentBoard, myBoard, opponentValidEnclosures, allDinos, turn);
                    double net = myGain - opGain;

                    if (net > bestValue)
                    {
                        bestValue = net;
                        bestDino = dinoCode;
                        bestCercado = cercado;
                    }
                }
            }

            if (bestDino == null) return null;
            return new string[] { bestDino, bestCercado };
        }

        private static double BestOpponentGain(
            List<string[]> hand,
            string playedDinoCode,
            List<string[]> opponentBoard,
            List<string[]> myBoard,
            List<string> opponentValidEnclosures,
            List<string[]> allDinos,
            int turn)
        {
            double best = 0;

            foreach (var dinoEntry in hand)
            {
                string dino = dinoEntry[0];
                int qty = 1;
                if (dinoEntry.Length >= 3) int.TryParse(dinoEntry[2], out qty);
                if (dino == playedDinoCode && qty <= 1) continue;

                foreach (string cercado in opponentValidEnclosures)
                {
                    double gain = BotScoring.MarginalScore(dino, cercado, opponentBoard, myBoard, allDinos, turn);
                    if (gain > best) best = gain;
                }
            }

            return best;
        }
    }
}
