using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //each frame has two turns
    //isspare means knock all balls in second turn in a frame
    //isstrike means knock all balls in first turn in a frame
    [SerializeField] private GameManager gameManager;

    private int totalScore;

    public int currentThrow { get; private set; }
    public int currentFrame { get; private set; }
    private int[] frames = new int[10];

    private bool isSpare = false;
    private bool isStrike = false;

    //Set value for our frame score each time we throw the ball
    public void SetFrameScore(int score)
    {
        //Ball 1
        if (currentThrow == 1)
        {
            frames[currentFrame - 1] += score; // Setting the right frame index and adding the score value from the parameter

            //Parallel process to check spare
            if (isSpare)
            {
                frames[currentFrame - 2] += score;
                isSpare = false;
            }

            if(score == 10)
            {
                if(currentFrame == 10)
                {
                    currentThrow++;   //wait for Ball 2
                }
                else
                {
                    isStrike = true;
                    currentFrame++; //Move to next frame since full mask obtained
                }

                //Reset all pins via gameManager
                gameManager.ResetAllPins();

            }
            else
            {
                currentThrow++;
            }

            return;
        }

        //Ball 2
        if (currentThrow == 2)
        {
            frames[currentFrame] += score;
            
            //Parallel process to check strike
            if (isStrike)
            {
                frames[currentFrame - 2] += frames[currentFrame - 1];
                isStrike = false;
            }

            if (frames[currentFrame-1] == 10) //Is total frame score is 10
            {
                if (currentFrame == 10)
                {
                    currentThrow++;//Wait for Ball 3
                }
                else
                {
                    isSpare = true;
                    currentFrame++;
                    currentThrow = 1;
                }
            }
            else
            {
                if(currentFrame == 10)
                {
                    //End of all throws
                    currentThrow = 0;
                    currentFrame = 0;
                }
                else
                {
                    currentFrame++;
                    currentThrow = 1;
                }

                //Reset all pins via gameManager
                gameManager.ResetAllPins();

                return;
            }
        }

        //Ball 3 ONLY FRAME 10
        if(currentThrow == 3 && currentFrame == 10)
        {
            frames[currentFrame - 1] += score;

            //End of all throws
            currentThrow = 0;
            currentFrame = 0;

            return;
        }

    }

    public int CalculateTotalScore()
    {
        totalScore = 0;
        foreach (var frame in frames)
        {
            totalScore += frame;
        }
        return totalScore;
    }

    private void ResetScore()
    {
        totalScore = 0;
        currentFrame = 1;
        currentThrow = 1;
        frames = new int[10];
    }
    
}
