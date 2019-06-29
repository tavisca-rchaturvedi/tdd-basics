using System;

namespace BowlingBall
{
    public class Game
    {
        private int score = 0;
        private int[] rolls;
        private int[] frames = new int[10];
        private int currentRoll = 0;


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
            while(rollCounter < rolls.Length){

                // Condition for a strike
                if(rolls[rollCounter] == 10)
                {
                    // adding 10 with score of next two rolls
                    score += 10 + rolls[rollCounter + 1] + rolls[rollCounter + 2];
                    frames[frameCounter] = 10 + rolls[rollCounter + 1] + rolls[rollCounter + 2];

                    // incrementing rollCounter by 1 as next roll will be for next frame
                    rollCounter += 1;
                }
                // Condition for a spare
                else if((rolls[rollCounter] + rolls[rollCounter + 1] ) == 10){
                    
                    // adding 10 with score of next roll i.e. first roll of next frame
                    score += 10 + rolls[rollCounter + 2];
                    frames[frameCounter] = 10 + rolls[rollCounter + 2];

                    // incrementing rollCounter by 2 as 2 rolls are of same frame and next roll will be in the next frame
                    rollCounter += 2;
                }
                // Condition for normal roll
                else
                {
                    score += rolls[rollCounter] + rolls[rollCounter + 1];
                    frames[frameCounter] = rolls[rollCounter] + rolls[rollCounter + 1];
                    rollCounter += 2;
                }
                //
                frameCounter++;
            }
            return score;
        }

    }
}

