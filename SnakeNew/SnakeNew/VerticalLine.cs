using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNew
{
    class VerticalLine : Figure
    {
        public VerticalLine (int yTop,int yBottom, int x,char sym)
        {
            ListP = new List<Point>();
            for (; yTop <= yBottom; yTop++)
            {
                Point p = new Point(x, yTop, sym);
                ListP.Add(p);
            }
        }
    }
}
