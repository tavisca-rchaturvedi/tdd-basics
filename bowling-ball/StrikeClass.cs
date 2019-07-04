using BowlingBall;
using System;


public class StrikeClass : IScoreCalculate
{
    public int CalculateScore(int[] rolls, int index) 
    {
        try
        {
            return 10 + rolls[index + 1] + rolls[index + 2];
        }
        catch (IndexOutOfRangeException e)
        {
            if (index + 1 < rolls.Length)
                return 10 + rolls[index + 1];
            else
                return 10;
        }
        
    }
}
