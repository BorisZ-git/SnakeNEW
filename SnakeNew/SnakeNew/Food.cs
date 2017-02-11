using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNew
{
    class Food
    {
        int mapWeidth;
        int mapHeight;
        char sym;
        Random random = new Random();
        public Food(int mapWeidth, int mapHeight,char sym)
        {
            this.mapHeight = mapHeight;
            this.mapWeidth = mapWeidth;
            this.sym = sym;
        }
        public Point CreateFood()
        {
            var x = random.Next(2, mapWeidth - 4);
            var y = random.Next(2, mapHeight - 4);
            Point p = new Point(x, y, sym);
            return p;
        }
    }
}
