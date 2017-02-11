using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNew
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft,int xRight,int y,char sym)
        {
            ListP = new List<Point>();
            for (; xLeft <= xRight; xLeft++)
            {
                Point p = new Point(xLeft, y, sym);
                ListP.Add(p);                
            }
        }
    }
}
