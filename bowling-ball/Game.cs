using System;
using BowlingBall;

namespace BowlingBall
{
    public class Game
    {
        private int score = 0;
        private int[] rolls;
        private int[] frames = new int[10];
        private int currentRoll = 0;
        private int currentScore = 0;


        public void InitializeRoll(int[] rollsVal)
        {
            rolls = rollsVal;
        }

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins; 
        }

        public int GetScore()
        {
            int rollCounter = 0;
            int frameCounter = 0;
            while(rollCounter < rolls.Length && rollCounter < 21){

                // Condition for a strike
                if(rollCounter + 1 < rolls.Length && IsStrike(rolls[rollCounter]))
                {


                    // adding 10 with score of next two rolls

                    CalculateScoreService temp = new CalculateScoreService(new StrikeClass());

                    score += temp.CalculateScore(rolls, rollCounter);
                    
                    // incrementing rollCounter by 1 as next roll will be for next frame
                    rollCounter += 1;
                }
                // Condition for a spare
                else if(rolls.Length > rollCounter + 1 && IsSpare(rolls[rollCounter] , rolls[rollCounter + 1] ))
                {

                    CalculateScoreService temp = new CalculateScoreService(new SpareClass());
                    score += temp.CalculateScore(rolls, rollCounter);
                    
                    // incrementing rollCounter by 2 as 2 rolls are of same frame and next roll will be in the next frame
                    rollCounter += 2;
                }
                // Condition for normal roll
                else
                {
                    CalculateScoreService temp = new CalculateScoreService(new NormalRoll());
                    score += temp.CalculateScore(rolls, rollCounter);
                    
                    rollCounter += 2;
                }
                //
                frameCounter++;
            }
            return score;
        }

        public void GetFrames()
        {

            // TODO: Convert Below Function using Strategy Pattern

            int rollCounter = 0;
            int frameCounter = 0;
            while(rollCounter <= rolls.Length)
            {
                if(rolls[rollCounter] == 10)
                {
                    frames[frameCounter] = 10 + rolls[rollCounter + 1] + rolls[rollCounter+2]; 
                    frameCounter++;
                    rollCounter++;
                }
                else
                {
                    if(frameCounter != 9)
                    {
                        frames[frameCounter] = rolls[rollCounter] + rolls[rollCounter + 1];
                        rollCounter += 2;
                        frameCounter++;
                    }
                    else
                    {
                        if(rolls[rollCounter] == 10)
                        {
                            frames[frameCounter] = rolls[rollCounter] + rolls[rollCounter + 2];
                        }
                        else
                        {
                            frames[frameCounter] = rolls[rollCounter] + rolls[rollCounter + 1] + rolls[rollCounter + 2]; 
                        }
                        
                        rollCounter += 3;
                        frameCounter++;
                    }
                }
            }
        }

        public bool IsStrike(int pins)
        {
            return pins == 10;
        }                     
        
        public bool IsSpare(int currentRoll, int nextRoll)
        {
            return currentRoll+nextRoll == 10;
        }

    }
}

