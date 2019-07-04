using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingBall
{
    interface IScoreCalculate
    {
        int CalculateScore(int[] rolls, int index);
    }
}
