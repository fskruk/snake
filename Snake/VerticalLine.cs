using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
        class VerticalLine
    {
        List<Point> pLine = new List<Point>();

        public VerticalLine(int x, int yUp, int yDown, char sym)
        {
            for(int y = yUp; y<=yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pLine.Add(p);

            }

        }

        public void Draw()
        {
            foreach(Point p in pLine)
            {
                p.Draw();
            }

        }


    }
}
