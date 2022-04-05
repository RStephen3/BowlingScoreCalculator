using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingLogic2021
{
    public class Ball
    {
        public Ball(int ballNumber)
        {
            Number = ballNumber;
        }
        public int Number { get; set; }
        public int Value { get; set; }
        public eMarkType MarkType { get; set; }
    }
}
