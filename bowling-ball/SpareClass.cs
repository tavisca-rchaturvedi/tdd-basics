using BowlingBall;
using System;

public class SpareClass : IScoreCalculate
{

    public int CalculateScore(int[] rolls, int index)
    {
        try
        {
            return 10 + rolls[index + 2];
        }
        catch(IndexOutOfRangeException e)
        {
            return 10;
        }
        
    }
}
