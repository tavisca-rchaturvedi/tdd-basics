using BowlingBall;
using System;


public class StrikeClass : IScoreCalculate
{
    public int CalculateScore(int[] rolls, int index) 
    {
        return 10 + rolls[index + 1] + rolls[index + 2];
    }
}
