using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNew
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public Point(int x,int y,char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Down)
            {
                y = y + offset;
            }
            else if (direction == Direction.Up)
            {
                y = y - offset;
            }
            else if (direction == Direction.Left)
            {
                x = x - offset;
            }
            else if (direction == Direction.Right)
            {
                x = x + offset;
            }
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        internal bool IsHit(Point p)
        {
            return p.x == x && p.y == y;
        }
    }
}
