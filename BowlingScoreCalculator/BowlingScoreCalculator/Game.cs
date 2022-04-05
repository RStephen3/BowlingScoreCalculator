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
            Frame1 = new Frame(1);
            Frame2 = new Frame(2);
            Frame3 = new Frame(3);
            Frame4 = new Frame(4);
            Frame5 = new Frame(5);
            Frame6 = new Frame(6);
            Frame7 = new Frame(7);
            Frame8 = new Frame(8);
            Frame9 = new Frame(9);
            Frame10 = new Frame(10);
        }
        public Frame Frame1 { get; set; }
        public Frame Frame2 { get; set; }
        public Frame Frame3 { get; set; }
        public Frame Frame4 { get; set; }
        public Frame Frame5 { get; set; }
        public Frame Frame6 { get; set; }
        public Frame Frame7 { get; set; }
        public Frame Frame8 { get; set; }
        public Frame Frame9 { get; set; }
        public Frame Frame10 { get; set; }
        public int TotalScore { get; set; }

        public Frame GetPrevFrame(int currFrameNumber)
        {
            switch (currFrameNumber)
            {
                case 2:
                    return Frame1;
                case 3:
                    return Frame2;
                case 4:
                    return Frame3;
                case 5:
                    return Frame4;
                case 6:
                    return Frame5;
                case 7:
                    return Frame6;
                case 8:
                    return Frame7;
                case 9:
                    return Frame8;
                case 10:
                    return Frame9;
                default:
                    return null;
            }
        }
        public int GetTotalScore(int currFrameNumber, int firstBallValue = 0)
        {
            switch (currFrameNumber)
            {
                case 1:
                    return Frame1.Score + firstBallValue;
                case 2:
                    return Frame2.Score + firstBallValue;
                case 3:
                    return Frame3.Score + firstBallValue;
                case 4:
                    return Frame4.Score + firstBallValue;
                case 5:
                    return Frame5.Score + firstBallValue;
                case 6:
                    return Frame6.Score + firstBallValue;
                case 7:
                    return Frame7.Score + firstBallValue;
                case 8:
                    return Frame8.Score + firstBallValue;
                case 9:
                    return Frame9.Score + firstBallValue;
                case 10:
                    return Frame10.Score + firstBallValue;
                default:
                    return 0;
            }
            return 0;
        }
    }
}
