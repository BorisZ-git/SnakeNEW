using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNew
{
    class Wall
    {
        List<Figure> ListWall = new List<Figure>();
        public Wall(int mapWidth,int mapHeight,char sym)
        {
            //set Window parametrs
            Console.SetBufferSize(mapWidth, mapHeight);
            //Create line
            HorizontalLine LineUp = new HorizontalLine(0, mapWidth - 2, 0, sym);
            HorizontalLine LineDown = new HorizontalLine(0, mapWidth - 2, mapHeight-1, sym);
            VerticalLine LineLeft = new VerticalLine(0, mapHeight - 2, 0, sym);
            VerticalLine LineRight = new VerticalLine(0, mapHeight - 2, mapWidth-1, sym);
            ListWall.Add(LineUp);
            ListWall.Add(LineDown);
            ListWall.Add(LineLeft);
            ListWall.Add(LineRight);
        }
        public void Draw()
        {
            foreach (var Line in ListWall)
            {
                Line.Draw();
            }
        }
    }
}
