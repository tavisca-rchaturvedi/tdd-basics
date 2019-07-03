using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingBall
{
    class NormalRoll : IScoreCalculate
    {
        public int CalculateScore(int[] rolls, int index)
        {
            if(index + 1 < rolls.Length)
            {
                return rolls[index] + rolls[index + 1];
            }
            else
            {
                return rolls[index];
            }
        }
    }
}
