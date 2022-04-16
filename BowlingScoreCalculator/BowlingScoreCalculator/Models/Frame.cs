using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreCalculator
{
    public class Frame
    {
        public Frame(int frameNumber)
        {
            Number = frameNumber;
            FirstBall = new Ball(1);
            SecondBall = new Ball(2);
            ThirdBall = new Ball(3);
        }

        public int Number { get; set; }
        public Ball FirstBall { get; set; }
        public Ball SecondBall { get; set; }
        public Ball ThirdBall { get; set; }
        public int Score { get; set; }
        public eMarkType MarkType { get; set; }
        public bool IsScoringComplete { get; set; }
    }
    public enum eMarkType
    {
        NotThrown,
        Strike,
        Spare,
        Open
    }
}
