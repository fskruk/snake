using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapW;
        int mapH;
        char sym;

        Random rand = new Random();

        public FoodCreator(int width, int height, char symb)
        {
            mapW = width;
            mapH = height;
            sym = symb;
        }
        public Point CreateFood()
        {
            int x = rand.Next(2, mapW - 2);
            int y = rand.Next(2, mapH - 2);
            return new Point(x, y, sym);
        }


    }
}
