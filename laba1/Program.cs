using System;
using laba1.services;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            FiguresDrawer figuresDrawer = new FiguresDrawer();
            figuresDrawer.PrintFiguresCollection();
        }
    }
}