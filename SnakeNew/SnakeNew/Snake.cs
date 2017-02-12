using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNew
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail,int lenght,Direction direction)
        {
            this.direction = direction;
            ListP = new List<Point>();
            for (int i=0;i<lenght;i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                ListP.Add(p); 
            }
        }        
        internal void Move()
        {
            Point tail = ListP.First();
            ListP.Remove(tail);
            Point head = GetNextPoint();
            ListP.Add(head);
            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = ListP.Last();
            Point NextPoint = new Point(head);
            NextPoint.Move(1,direction);
            return NextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.Down;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.Up;
            }
            else if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.Left;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.Right;
            }
        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                ListP.Add(food);
                return true;
            }
            else return false;
        }
    }
}
