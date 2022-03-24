namespace laba1.models
{
    public class Circle: IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}