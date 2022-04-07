using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingLogic2021
{
    public class Game
    {
        public Game()
        {
            Frames = new List<Frame>();
            Frames.Add(new Frame(1));
            Frames.Add(new Frame(2));
            Frames.Add(new Frame(3));
            Frames.Add(new Frame(4));
            Frames.Add(new Frame(5));
            Frames.Add(new Frame(6));
            Frames.Add(new Frame(7));
            Frames.Add(new Frame(8));
            Frames.Add(new Frame(9));
            Frames.Add(new Frame(10));
        }
        public List<Frame> Frames { get; set; }
        public int TotalScore { get; set; }

        public Frame GetFrame(int frameNumber)
        {
            foreach (Frame frame in Frames)
            {
                if (frame.Number == frameNumber)
                    return frame;
            }
            return null;
        }
        public void GetTotalScore(Frame frame, int firstBallValue = 0)
        {
            if (!frame.IsScoringComplete)
                frame.Score = frame.Score + firstBallValue;
        }
    }
}
