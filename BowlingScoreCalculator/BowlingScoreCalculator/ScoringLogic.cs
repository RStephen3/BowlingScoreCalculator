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
        public static Game game = null;
        private static bool updateEntireScore = false;
        public static bool ShotLogic(string ballText, Frame currFrame, int ballNumber, bool updating = false)
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

            if (updateEntireScore && !updating)
            {
                updateAllFrames();
                return true;
            }
            else
            {
                updatePreviousFrames(currFrame, ballNumber);

                Frame prevFrame = game.GetFrame(currFrame.Number - 1);
                if (prevFrame != null)
                    currFrame.Score += prevFrame.Score;
                return false;
            }
        }
        private static void getFirstBallValue(Frame frame, string ballText)
        {
            if (frame.FirstBall.Value != 0 && !updateEntireScore)
            {
                MarkFramesDirty(frame, 1);
            }
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
                    frame.Score = frame.FirstBall.Value;
                    break;
            }
        }
        private static void getSecondBallValue(Frame frame, string ballText)
        {
            if (frame.SecondBall.Value != 0 && !updateEntireScore)
            {
                MarkFramesDirty(frame, 2);
            }
            frame.SecondBall.MarkType = getMarkType(ballText);
            switch (frame.SecondBall.MarkType)
            {
                case eMarkType.Strike:
                    if (frame.Number != 10)
                        throw new Exception("Please enter a valid score");
                    frame.SecondBall.Value = 10;
                    strikeLogic(frame);
                    frame.Score = frame.FirstBall.Value + frame.SecondBall.Value;
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
                    frame.Score = frame.FirstBall.Value + frame.SecondBall.Value;
                    break;
            }
        }
        private static void getThirdBallValue(Frame frame, string ballText)
        {
            if (frame.ThirdBall.Value != 0 && !updateEntireScore)
            {
                MarkFramesDirty(frame, 3);
            }
            frame.ThirdBall.MarkType = getMarkType(ballText);
            switch (frame.ThirdBall.MarkType)
            {
                case eMarkType.Strike:
                    frame.ThirdBall.Value = 10;
                    strikeLogic(frame);
                    frame.Score = frame.FirstBall.Value + frame.SecondBall.Value + 10;
                    break;
                case eMarkType.Spare:
                    frame.ThirdBall.Value = 10 - frame.FirstBall.Value;
                    spareLogic(frame);
                    frame.Score = frame.FirstBall.Value + frame.SecondBall.Value + 10;
                    break;
                case eMarkType.Open:
                    if (ballText == "-")
                        frame.ThirdBall.Value = 0;
                    else
                        frame.ThirdBall.Value = int.Parse(ballText);
                    if (frame.FirstBall.Value + frame.SecondBall.Value > 10)
                        throw new Exception("You have entered a number higher than the remaining number of pins. Please enter a valid score");
                    openLogic(frame, true);
                    frame.Score = frame.FirstBall.Value + frame.SecondBall.Value + frame.ThirdBall.Value;
                    break;
            }
        }
        private static void updatePreviousFrames(Frame currFrame, int ballNumber)
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
                            game.GetTotalScore(prevprevFrame, currFrame.FirstBall.Value);
                            prevprevFrame.IsScoringComplete = true;
                            if (currFrame.Number == 10 && ballNumber == 2 && currFrame.SecondBall.MarkType == eMarkType.Strike)
                            {
                                game.GetTotalScore(prevFrame, currFrame.FirstBall.Value);
                                prevFrame.IsScoringComplete = true;
                            }
                            else
                            {
                                game.GetTotalScore(prevFrame, currFrame.FirstBall.Value);
                            }
                        }
                        else
                        {
                            prevFrame.IsScoringComplete = true;
                        }
                    }
                    //when prev frame is a strike
                    game.GetTotalScore(prevFrame, currFrame.FirstBall.Value);
                }
                else if (prevFrame.MarkType == eMarkType.Spare)
                {
                    //when prev frame is a spare
                    game.GetTotalScore(prevFrame, currFrame.FirstBall.Value);
                    prevFrame.IsScoringComplete = true;
                }
            }
        }
        private static void updateAllFrames()
        {
            foreach (Frame frame in game.Frames)
            {
                frame.IsScoringComplete = false;
                for (int i = 1; i <= 3; i++)
                {
                    string ballText = "";
                    switch (i)
                    {
                        case 1:
                            ballText = frame.FirstBall.Value.ToString();
                            if (frame.FirstBall.MarkType == eMarkType.Strike)
                                ballText = "X";

                            ShotLogic(ballText, frame, 1, true);
                            break;
                        case 2:
                            ballText = frame.SecondBall.Value.ToString();
                            if (frame.SecondBall.MarkType == eMarkType.Strike)
                                ballText = "X";
                            else if (frame.SecondBall.MarkType == eMarkType.Spare)
                                ballText = "/";
                            ShotLogic(ballText, frame, 2, true);
                            break;
                        case 3:
                            if (frame.Number == 10)
                            {
                                ballText = frame.ThirdBall.Value.ToString();
                                if (frame.ThirdBall.MarkType == eMarkType.Strike)
                                    ballText = "X";
                                else if (frame.ThirdBall.MarkType == eMarkType.Spare)
                                    ballText = "/";
                                ShotLogic(ballText, frame, 3, true);
                            }
                            break;
                    }
                }

                //    updatePreviousFrames(frame, ballNumber);

                //    Frame previousFrame = game.GetFrame(i - 1);
                //    frame.Score += previousFrame.Score;
                //}
                //Frame prevFrame = game.GetFrame(currFrame.Number - 1);
                //if (prevFrame != null && prevFrame.MarkType != eMarkType.Open)
                //{
                //    if (prevFrame.MarkType == eMarkType.Strike)
                //    {
                //        Frame prevprevFrame = game.GetFrame(prevFrame.Number - 1);
                //        if (prevprevFrame != null && prevprevFrame.MarkType != eMarkType.Open)
                //        {
                //            if (prevprevFrame.MarkType == eMarkType.Strike)
                //            {
                //                //when we are on a double
                //                game.GetTotalScore(prevprevFrame, currFrame.FirstBall.Value);
                //                prevprevFrame.IsScoringComplete = true;
                //                if (currFrame.Number == 10 && ballNumber == 2 && currFrame.SecondBall.MarkType == eMarkType.Strike)
                //                {
                //                    game.GetTotalScore(prevFrame, currFrame.FirstBall.Value);
                //                    prevFrame.IsScoringComplete = true;
                //                }
                //                else
                //                {
                //                    game.GetTotalScore(prevFrame, currFrame.FirstBall.Value);
                //                }
                //            }
                //            else
                //            {
                //                prevFrame.IsScoringComplete = true;
                //            }
                //        }
                //        //when prev frame is a strike
                //        game.GetTotalScore(prevFrame, currFrame.FirstBall.Value);
                //    }
                //    else if (prevFrame.MarkType == eMarkType.Spare)
                //    {
                //        //when prev frame is a spare
                //        game.GetTotalScore(prevFrame, currFrame.FirstBall.Value);
                //        prevFrame.IsScoringComplete = true;
                //    }
            }
            updateEntireScore = false;
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
        private static void MarkFramesDirty(Frame currFrame, int ballNumber)
        {
            updateEntireScore = true;
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
                            prevprevFrame.IsScoringComplete = false;
                            if (currFrame.Number == 10 && ballNumber == 2 && currFrame.SecondBall.MarkType == eMarkType.Strike)
                            {
                                prevFrame.IsScoringComplete = false;
                            }
                        }
                        else
                        {
                            prevFrame.IsScoringComplete = false;
                        }
                    }
                }
                else if (prevFrame.MarkType == eMarkType.Spare)
                {
                    prevFrame.IsScoringComplete = false;
                }
            }
        }
    }
}
