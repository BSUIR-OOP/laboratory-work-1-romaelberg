namespace laba1.models
{
    public class Line: IShape
    {
        public int X1 { get; set; }
        public int X2 { get; set; }

        public Line(int x1, int x2)
        {
            X1 = x1;
            X2 = x2;
        }

        public void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}