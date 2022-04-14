using System;
using laba1.models;
namespace laba1.services

{
    public class LineDrawer: Line, IDrawer
    {
        public LineDrawer(double width) : base(width) {}
        public void PrintInfo()
        {
            Console.WriteLine("Line({0})", Width);
        }
    }
}