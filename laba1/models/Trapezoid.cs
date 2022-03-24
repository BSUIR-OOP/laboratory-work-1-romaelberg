namespace laba1.models
{
    // TODO: validation for props
    public class Trapezoid: IShape
    {
        private double X1 { get; set; }
        private double X2 { get; set; }
        private double Y1 { get; set; }
        private double Y2 { get; set; }

        public Trapezoid(double x1, double x2, double y1, double y2)
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