using System;

namespace laba1.models
{
    public class Rectangle
    {
        protected double Width { get; set; }
        protected double Height { get; set; }

        protected Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}