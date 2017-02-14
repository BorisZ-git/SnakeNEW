using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNew
{
    class Figure
    {
        protected List<Point> ListP;
        public void Draw()
        {
            foreach (var i in ListP)
            {
                i.Draw();
            }
        }
        public bool IsHit (Figure figureSnake)
        {
            foreach (var WallP in ListP)
            {
                if (figureSnake.IsHit(WallP))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsHit (Point WallP)
        {
            foreach (var p in ListP)
            {
                if (WallP.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
