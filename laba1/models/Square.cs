using System.Buffers.Text;

namespace laba1.models
{
    public class Square
    {
        protected double SideLength { get; set; }
        protected Square(double sideLength)
        {
            SideLength = sideLength;
        }
    }
}