using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Currently getting 310 or 290 for 300. Something with 3rd ball. 
namespace BowlingLogic2021
{
    public class ScoringLogic
    {
        public static void ShotLogic(Game game, string ballText, Frame currFrame, int ballNumber)
        {
            //Get value of shot thrown
            switch (ballNumber)
            {
                case 1:
                    getFirstBallValue(currFrame, ballText);
                    break;
                case 2:
                    getSecondBallValue(currFrame, ballText);
                    break;
                case 3:
                    getThirdBallValue(currFrame, ballText);
                    break;
            }
            //TODO: Instead of grabbing previous frame and previous previous freame, just recalculate the whole game each time a score is made. 
            //foreach (Frame frame in game.Frames)
            //{
            //    if (!frame.IsScoringComplete)
            //    {
            Frame prevFrame = game.GetFrame(currFrame.Number - 1);
            if (prevFrame != null)
                currFrame.Score += prevFrame.Score;
            if (ballNumber == 3)
                currFrame.Score += currFrame.ThirdBall.Value;
            else
                checkPreviousFrames(game, currFrame, ballNumber);
            //    }
            //}
        }
        private static void getFirstBallValue(Frame frame, string ballText)
        {
            frame.FirstBall.MarkType = getMarkType(ballText);
            switch (frame.FirstBall.MarkType)
            {
                case eMarkType.Strike:
                    frame.FirstBall.Value = 10;
                    strikeLogic(frame);
                    break;
                case eMarkType.Open:
                    if (ballText == "-")
                        frame.FirstBall.Value = 0;
                    else
                        frame.FirstBall.Value = int.Parse(ballText);
                    openLogic(frame);
                    break;
            }
        }
        private static void getSecondBallValue(Frame frame, string ballText)
        {
            frame.SecondBall.MarkType = getMarkType(ballText);
            switch (frame.SecondBall.MarkType)
            {
                case eMarkType.Strike:
                    if (frame.Number != 10)
                        throw new Exception("Please enter a valid score");
                    frame.SecondBall.Value = 10;
                    strikeLogic(frame);
                    break;
                case eMarkType.Spare:
                    frame.SecondBall.Value = 10 - frame.FirstBall.Value;
                    spareLogic(frame);
                    break;
                case eMarkType.Open:
                    if (ballText == "-")
                        frame.SecondBall.Value = 0;
                    else
                        frame.SecondBall.Value = int.Parse(ballText);
                    if (frame.FirstBall.Value + frame.SecondBall.Value > 10)
                        throw new Exception("You have entered a number higher than the remaining number of pins. Please enter a valid score");
                    openLogic(frame, true);
                    break;
            }
        }
        private static void getThirdBallValue(Frame frame, string ballText)
        {
            frame.ThirdBall.MarkType = getMarkType(ballText);
            switch (frame.ThirdBall.MarkType)
            {
                case eMarkType.Strike:
                    frame.ThirdBall.Value = 10;
                    strikeLogic(frame);
                    break;
                case eMarkType.Spare:
                    frame.ThirdBall.Value = 10 - frame.FirstBall.Value;
                    spareLogic(frame);
                    break;
                case eMarkType.Open:
                    if (ballText == "-")
                        frame.ThirdBall.Value = 0;
                    else
                        frame.ThirdBall.Value = int.Parse(ballText);
                    if (frame.FirstBall.Value + frame.SecondBall.Value > 10)
                        throw new Exception("You have entered a number higher than the remaining number of pins. Please enter a valid score");
                    openLogic(frame, true);
                    break;
            }
        }
        private static void checkPreviousFrames(Game game, Frame currFrame, int ballNumber)
        {
            Frame prevFrame = game.GetFrame(currFrame.Number - 1);
            if (prevFrame != null && prevFrame.MarkType != eMarkType.Open)
            {
                if (prevFrame.MarkType == eMarkType.Strike)
                {
                    Frame prevprevFrame = game.GetFrame(prevFrame.Number - 1);
                    if (prevprevFrame != null && prevprevFrame.MarkType != eMarkType.Open)
                    {
                        if (prevprevFrame.MarkType == eMarkType.Strike)
                        {
                            //when we are on a double
                            prevprevFrame.Score = game.GetTotalScore(prevprevFrame, currFrame.FirstBall.Value);
                            prevprevFrame.IsScoringComplete = true;
                            prevFrame.Score = game.GetTotalScore(prevFrame, currFrame.FirstBall.Value);
                            currFrame.Score = game.GetTotalScore(currFrame, currFrame.FirstBall.Value);
                        }
                        else
                        {
                            prevFrame.IsScoringComplete = true;
                        }
                    }
                    //when prev frame is a strike
                    prevFrame.Score = game.GetTotalScore(prevFrame, currFrame.FirstBall.Value);
                    currFrame.Score = game.GetTotalScore(currFrame, currFrame.FirstBall.Value);
                }
                else if (prevFrame.MarkType == eMarkType.Spare)
                {
                    //when prev frame is a spare
                    prevFrame.Score = game.GetTotalScore(prevFrame, currFrame.FirstBall.Value);
                    prevFrame.IsScoringComplete = true;
                    currFrame.Score = game.GetTotalScore(currFrame, currFrame.FirstBall.Value);
                }
            }
        }
        private static void strikeLogic(Frame frame)
        {
            frame.Score = 10;
            frame.MarkType = eMarkType.Strike;
        }
        private static void spareLogic(Frame frame)
        {
            frame.Score = 10;
            frame.MarkType = eMarkType.Spare;
        }
        private static void openLogic(Frame frame, bool isFinal = false)
        {
            frame.Score = frame.FirstBall.Value + frame.SecondBall.Value;
            if (isFinal)
            {
                frame.IsScoringComplete = true;
                frame.MarkType = eMarkType.Open;
            }
        }
        private static eMarkType getMarkType(string ballValue)
        {
            switch (ballValue)
            {
                case "X":
                    return eMarkType.Strike;
                case "/":
                    return eMarkType.Spare;
                default:
                    return eMarkType.Open;
            }
        }
    }
}
