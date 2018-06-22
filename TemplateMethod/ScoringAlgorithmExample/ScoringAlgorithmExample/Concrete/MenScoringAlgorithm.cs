using ScoringAlgorithmExample.Abstract;
using System;

namespace ScoringAlgorithmExample.Concrete
{
    class MenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }
    }
}
