using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingBall
{
    class CalculateScoreService
    {
        readonly IScoreCalculate scoreCalculateStrategy;

        public CalculateScoreService(IScoreCalculate scoreCalculateStrategy)
        {
            this.scoreCalculateStrategy = scoreCalculateStrategy;
        }

        public int CalculateScore (int[] rolls, int index)
        {
            return this.scoreCalculateStrategy.CalculateScore(rolls, index);
        }
    }
}
