using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNew
{
    class Snake : Figure
    {
        
        public Snake(Point tail,int lenght,Direction direction)
        {
            ListP = new List<Point>();
            for (int i=0;i<=lenght;i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                ListP.Add(p); 
            }
        }
        public void Draw()
        {
            foreach (var p in ListP)
            {
                p.Draw();
            }
        }
    }
}
