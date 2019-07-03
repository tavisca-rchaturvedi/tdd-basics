using BowlingBall;
using System;

public class SpareClass : IScoreCalculate
{

    public int CalculateScore(int[] rolls, int index)
    {
        return 10 + rolls[index + 2]; 
    }
}
