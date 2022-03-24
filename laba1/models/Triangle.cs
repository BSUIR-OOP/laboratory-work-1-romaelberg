namespace laba1.models
{
    public class Triangle: IShape
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double X3 { get; set; }

        public Triangle(double x1, double x2, double x3)
        {
            X1 = x1;
            X2 = x2;
            X3 = x3;
        }

        public void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}