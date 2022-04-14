using System.Collections.Generic;

namespace laba1.services
{
    public class FiguresDrawer
    {
        private readonly List<IDrawer> _drawersList = new List<IDrawer>();
        public FiguresDrawer()
        {
            FillFiguresCollection();
        }
        private void FillFiguresCollection()
        {
            _drawersList.Add(new CircleDrawer(40));
            _drawersList.Add(new SquareDrawer(10));
            _drawersList.Add(new RectangleDrawer(10, 20));
            _drawersList.Add(new TriangleDrawer(20, 10, 20));
            _drawersList.Add(new TrapezoidDrawer(10, 20, 30, 40));
            _drawersList.Add(new LineDrawer(10));
        }

        public void PrintFiguresCollection()
        {
            foreach (IDrawer drawer in _drawersList)
            {
                drawer.PrintInfo();
            }
        }
    }
}