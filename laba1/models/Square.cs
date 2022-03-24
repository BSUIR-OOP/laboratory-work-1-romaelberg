using System.Buffers.Text;

namespace laba1.models
{
    public class Square: Rectangle
    {
        public Square(double x1, double x2) : base(x1, x2, x1+x1, x2+x2)
        {
        }
    }
}