using System;
using laba1.models;
namespace laba1.services

{
    public class RectangleDrawer: Rectangle, IDrawer
    {
        public RectangleDrawer(double width, double height) : base(width, height) {}
        public void PrintInfo()
        {
            Console.WriteLine("Rectangle({0}, {1})", Width, Height);
        }
    }
}