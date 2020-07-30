using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        

        


        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Point p1 = new Point(6, 3, '*');

            p1.Draw();

            Point p2 = new Point(4, 5, '8');
                    
            p2.Draw();

            HorizontalLine upLine = new HorizontalLine(0, 79, 1, '#');
            upLine.Draw();
            HorizontalLine downLine = new HorizontalLine(0, 79, 24, '#');
            downLine.Draw();

            VerticalLine RLine = new VerticalLine(0, 1, 23, '#');
            RLine.Draw();
            VerticalLine LLine = new VerticalLine(79, 1, 23, '#');
            LLine.Draw();

            Console.ReadLine();
        }
    }
}
