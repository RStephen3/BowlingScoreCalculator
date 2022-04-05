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
        public int GetTotalScore(Frame frame, int firstBallValue = 0)
        {
            if (!frame.IsScoringComplete)
                return frame.Score + firstBallValue;
            return frame.Score;
        }
    }
}
