using System;

namespace laba1.models
{
    public class Trapezoid
    {
        protected double LeftSide;

        protected double RightSide;

        protected double BottomSide;
        protected double TopSide;
        

        protected Trapezoid(double leftSide, double rightSide, double topSide, double bottomSide)
        {
            LeftSide = leftSide;
            RightSide = rightSide;
            TopSide = topSide;
            BottomSide = bottomSide;
        }
    }
}