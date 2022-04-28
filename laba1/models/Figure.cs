using System.Collections;
using System.Collections.Generic;
using laba1.interfaces;

namespace laba1.models
{
    public abstract class Figure: IFigure
    {
        public abstract IEnumerable<Dot> GenerateDots();
    }
}