using System;

namespace ScoringAlgorithmExample.Abstract
{
    abstract class ScoringAlgorithm
    {
        // Template metod
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOverallScore(score, reduction);
        }

        private int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        // Primitif metodlar
        public abstract int CalculateBaseScore(int hits);
        public abstract int CalculateReduction(TimeSpan time);
    }
}
