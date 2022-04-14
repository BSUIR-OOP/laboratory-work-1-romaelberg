using System;
using System.Collections.Generic;
using laba1.models;

namespace laba1.services
{
    public class CircleDrawer: Circle, IDrawer
    {
        public CircleDrawer(double radius) : base(radius) {}

        public void PrintInfo()
        {
            Console.WriteLine("Circle ({0})", Radius);
        }
    }
}