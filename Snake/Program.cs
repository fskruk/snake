using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
            int w = 80;
            int h = 25;            
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
            Console.CursorVisible = false;


            //Point p1 = new Point(6, 3, '*');

            //p1.Draw();
            //отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, w-1, 1, '#');
            upLine.Draw();
            HorizontalLine downLine = new HorizontalLine(0, w-1, h-1, '#');
            downLine.Draw();
            VerticalLine RLine = new VerticalLine(0, 1, h-2, '#');
            RLine.Draw();
            VerticalLine LLine = new VerticalLine(w-1, 1, h-2, '#');
            LLine.Draw();

            //начальное положение змейки
            Point p1 = new Point( w/2, h/2, '#');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator( w, h,'8');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while (true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();                    
                    
                }

                Thread.Sleep(100);
                snake.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);                    
                }


                
                                
            }

            Console.ReadLine();
        }
    }
}
