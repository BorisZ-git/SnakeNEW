﻿using System;
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
    }
}