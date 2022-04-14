using System;
using laba1.models;
namespace laba1.services

{
    public class TrapezoidDrawer: Trapezoid, IDrawer
    {
        public TrapezoidDrawer(double leftSide, double rightSide, double topSide, double bottomSide) : base(leftSide, rightSide,topSide,bottomSide) {}
        public void PrintInfo()
        {
            Console.WriteLine("Trapezoid({0}, {1}, {2}, {3})", LeftSide, RightSide, TopSide, BottomSide);
        }
    }
}