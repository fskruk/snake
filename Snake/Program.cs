using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        

        


        static void Main(string[] args)
        {
            //размер окна и буфера
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //Point p1 = new Point(6, 3, '*');

            //p1.Draw();
            //отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, 79, 1, '#');
            upLine.Draw();
            HorizontalLine downLine = new HorizontalLine(0, 79, 24, '#');
            downLine.Draw();
            VerticalLine RLine = new VerticalLine(0, 1, 23, '#');
            RLine.Draw();
            VerticalLine LLine = new VerticalLine(79, 1, 23, '#');
            LLine.Draw();

            //начальное положение змейки
            Point p1 = new Point(39, 12, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();
            while (true)
            {
                snake.Move();
                Thread.Sleep(300);                
            }

            Console.ReadLine();
        }
    }
}
