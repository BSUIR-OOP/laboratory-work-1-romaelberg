using System.Collections;
using System.Collections.Generic;
using laba1.models;

namespace laba1.interfaces
{
    public interface IFigure
    {
        public IEnumerable<Dot> GenerateDots();
    }
}