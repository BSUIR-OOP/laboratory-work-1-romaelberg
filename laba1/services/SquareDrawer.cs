using System;
using laba1.models;
namespace laba1.services

{
    public class SquareDrawer: Square, IDrawer
    {
        public SquareDrawer(double sideLength) : base(sideLength) {}
        public void PrintInfo()
        {
            Console.WriteLine("Square({0})", SideLength);
        }
    }
}