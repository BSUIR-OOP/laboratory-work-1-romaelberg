using System;
using laba1.models;
namespace laba1.services

{
    public class TriangleDrawer: Triangle, IDrawer
    {
        public TriangleDrawer(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide) {}
        public void PrintInfo()
        {
            Console.WriteLine("Rectangle({0}, {1}, {2})", FirstSide, SecondSide, ThirdSide);
        }
    }
}