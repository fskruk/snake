using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class walls
    {
        List<Figure> wList = new List<Figure>();
        public walls(int w, int h)
        {
            HorizontalLine upLine = new HorizontalLine(0, w - 1, 1, '#');
            //upLine.Draw();
            HorizontalLine downLine = new HorizontalLine(0, w - 1, h - 1, '#');
            //downLine.Draw();
            VerticalLine RLine = new VerticalLine(0, 1, h - 2, '#');
            //RLine.Draw();
            VerticalLine LLine = new VerticalLine(w - 1, 1, h - 2, '#');
            //LLine.Draw();
            wList.Add(upLine);
            wList.Add(downLine);
            wList.Add(RLine);
            wList.Add(LLine);

        }
        public void Draw()
        {
            foreach(var wall in wList)
            {
                wall.Draw();
            }

        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wList)
            {
                if (wall.IsHit(figure))
                    return true; 
            }
            return false;
                
                
                        
        }

    }
}
