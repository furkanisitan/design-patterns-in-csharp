using ScoringAlgorithmExample.Abstract;
using System;

namespace ScoringAlgorithmExample.Concrete
{
    class ChildrenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 150;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3;
        }
    }
}
