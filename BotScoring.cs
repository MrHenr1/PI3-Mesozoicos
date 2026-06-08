using System;
using System.Collections.Generic;

namespace Mesozoicos
{
    public static class BotScoring
    {
        private static readonly int[] ScoreFI = { 0, 2, 4, 8, 12, 18, 24 };
        private static readonly int[] ScoreCD = { 0, 1, 3, 6, 10, 15, 21 };

        public static string GetSpecies(string dinoCode, List<string[]> allDinos)
        {
            foreach (var d in allDinos)
                if (d.Length >= 3 && d[0].Trim() == dinoCode.Trim())
                    return d[2].Trim().ToLower();
            return dinoCode.ToLower();
        }

        private static bool IsTRex(string dinoCode, List<string[]> allDinos)
            => GetSpecies(dinoCode, allDinos).Contains("vermelho");

        public static int GetEnclosureCount(string cercadoCode, List<string[]> board)
        {
            int total = 0;
            foreach (var e in board)
            {
                if (e[0] != cercadoCode) continue;
                int q = 1;
                if (e.Length >= 5) int.TryParse(e[4], out q);
                total += Math.Max(1, q);
            }
            return total;
        }

        public static int GetSpeciesCountInBoard(string species, List<string[]> board, List<string[]> allDinos)
        {
            int count = 0;
            foreach (var e in board)
            {
                if (!string.Equals(GetSpecies(e[2], allDinos), species, StringComparison.OrdinalIgnoreCase)) continue;
                int q = 1;
                if (e.Length >= 5) int.TryParse(e[4], out q);
                count += Math.Max(1, q);
            }
            return count;
        }

        private static string GetFISpecies(List<string[]> board, List<string[]> allDinos)
        {
            foreach (var e in board)
                if (e[0] == "FI") return GetSpecies(e[2], allDinos);
            return null;
        }

        private static HashSet<string> GetSpeciesInEnclosure(string cercadoCode, List<string[]> board, List<string[]> allDinos)
        {
            var set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var e in board)
                if (e[0] == cercadoCode)
                    set.Add(GetSpecies(e[2], allDinos));
            return set;
        }

        public static bool EnclosureHasTRex(string cercadoCode, List<string[]> board, List<string[]> allDinos)
        {
            foreach (var e in board)
                if (e[0] == cercadoCode && IsTRex(e[2], allDinos)) return true;
            return false;
        }

        public static bool CanPlace(string dinoCode, string cercadoCode, List<string[]> board, List<string[]> allDinos)
        {
            int count = GetEnclosureCount(cercadoCode, board);
            string species = GetSpecies(dinoCode, allDinos);

            switch (cercadoCode)
            {
                case "FI":
                    if (count >= 6) return false;
                    var fiSpecies = GetFISpecies(board, allDinos);
                    return fiSpecies == null || string.Equals(fiSpecies, species, StringComparison.OrdinalIgnoreCase);

                case "CD":
                    if (count >= 6) return false;
                    return !GetSpeciesInEnclosure("CD", board, allDinos).Contains(species);

                case "MT":
                    return count < 3;

                case "RS":
                case "IS":
                    return count == 0;

                case "PA":
                    return count < 6;

                default:
                    return true;
            }
        }

        public static double MarginalScore(
            string dinoCode, string cercadoCode,
            List<string[]> myBoard, List<string[]> opponentBoard,
            List<string[]> allDinos, int turn)
        {
            if (!CanPlace(dinoCode, cercadoCode, myBoard, allDinos))
                return double.MinValue;

            double score = RawScore(dinoCode, cercadoCode, myBoard, opponentBoard, allDinos);

            if (IsTRex(dinoCode, allDinos) && cercadoCode != "RI" && !EnclosureHasTRex(cercadoCode, myBoard, allDinos))
                score += 1.0;

            return score * Confidence(cercadoCode, turn, dinoCode, myBoard, opponentBoard, allDinos);
        }

        private static double RawScore(
            string dinoCode, string cercadoCode,
            List<string[]> myBoard, List<string[]> opponentBoard,
            List<string[]> allDinos)
        {
            string species = GetSpecies(dinoCode, allDinos);
            int count = GetEnclosureCount(cercadoCode, myBoard);

            switch (cercadoCode)
            {
                case "FI":
                    return ScoreFI[Math.Min(count + 1, 6)] - ScoreFI[Math.Min(count, 6)];

                case "CD":
                    return ScoreCD[Math.Min(count + 1, 6)] - ScoreCD[Math.Min(count, 6)];

                case "PA":
                    int paCount = 0;
                    foreach (var e in myBoard)
                    {
                        if (e[0] != "PA") continue;
                        if (!string.Equals(GetSpecies(e[2], allDinos), species, StringComparison.OrdinalIgnoreCase)) continue;
                        int q = 1;
                        if (e.Length >= 5) int.TryParse(e[4], out q);
                        paCount += Math.Max(1, q);
                    }
                    return paCount % 2 == 1 ? 5.0 : 1.0;

                case "MT":
                    if (count == 2) return 7.0;
                    return count == 1 ? 2.0 : 1.2;

                case "RS":
                    int myRsCount = GetSpeciesCountInBoard(species, myBoard, allDinos) + 1;
                    int opRsCount = opponentBoard != null ? GetSpeciesCountInBoard(species, opponentBoard, allDinos) : 0;
                    return myRsCount >= opRsCount ? 7.0 : 0.0;

                case "IS":
                    return GetSpeciesCountInBoard(species, myBoard, allDinos) == 0 ? 7.0 : 0.0;

                default:
                    return 1.0;
            }
        }

        private static double Confidence(string cercadoCode, int turn, string dinoCode, List<string[]> myBoard, List<string[]> opponentBoard, List<string[]> allDinos)
        {
            switch (cercadoCode)
            {
                case "RS":
                    if (turn < 7) return 0.05;
                    string rsSpecies = GetSpecies(dinoCode, allDinos);
                    int myRs = GetSpeciesCountInBoard(rsSpecies, myBoard, allDinos) + 1;
                    int opRs = opponentBoard != null ? GetSpeciesCountInBoard(rsSpecies, opponentBoard, allDinos) : 0;
                    if (myRs < opRs) return 0.0;
                    int rsLead = myRs - opRs;
                    if (rsLead >= 2) return 0.9;
                    if (rsLead == 1) return turn >= 10 ? 0.85 : 0.45;
                    return turn >= 12 ? 0.7 : turn >= 10 ? 0.35 : 0.1;

                case "IS":
                    if (turn < 7) return 0.05;
                    string isSpecies = GetSpecies(dinoCode, allDinos);
                    int myIs = GetSpeciesCountInBoard(isSpecies, myBoard, allDinos);
                    int opIs = opponentBoard != null ? GetSpeciesCountInBoard(isSpecies, opponentBoard, allDinos) : 0;
                    int seenTotal = myIs + opIs;
                    double isBase = turn >= 12 ? 1.0 : turn >= 10 ? 0.75 : 0.35;
                    double rarityBoost = Math.Min(0.4, seenTotal * 0.1);
                    return Math.Min(1.0, isBase + rarityBoost);

                case "FI":
                    var fiSpecies = GetFISpecies(myBoard, allDinos);
                    bool fiCommitted = fiSpecies != null && string.Equals(fiSpecies, GetSpecies(dinoCode, allDinos), StringComparison.OrdinalIgnoreCase);
                    if (fiCommitted) return 1.0;
                    return turn >= 7 ? 1.0 : 0.7;

                case "MT":
                    return turn >= 7 ? 1.0 : 0.9;

                default:
                    return 1.0;
            }
        }
    }
}
