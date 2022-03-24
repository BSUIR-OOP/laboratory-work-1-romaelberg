using System;

namespace laba1.models
{
    public class Rectangle: IShape
    {
        private double X1 { get; set; }
        private double X2 { get; set; }
        private double Y1 { get; set; }
        private double Y2 { get; set; }

        public Rectangle(double x1, double x2, double y1, double y2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }

        public void Draw()
        {
            throw new System.NotImplementedException();
        }
        
    }
}