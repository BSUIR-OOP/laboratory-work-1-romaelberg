namespace laba1.models
{
    public class Triangle
    {
        protected double FirstSide { get; set; }
        protected double SecondSide { get; set; }
        protected double ThirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
    }
}