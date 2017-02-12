using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Introduce yourself please:");
            string name = Console.ReadLine();
            Console.WriteLine("Glad to see you " + name + "\nlet start");
            Console.Clear();
            // We need realize game snake.Where snake move in space that we give to her,
            // and eat food that we will be create in random position. When snake eat food
            // she will be grow. Game will be end if snake bite herself or hit wall of space
            // that we give for her.

            //Our snake will be consist of points, so the first thing that we need to do, it's realize
            //class poitns. Then we do it next step will be realize snake that consist of points, so we
            //need realize class snake that will be responsible for grouping points into snake.
            //Next step will be give snake a space to exist. We will realize it in class wall, that 
            //will be use another class that help build frame with horizontal line and vertical line.
            //Now it's time for create food. We create class that will be generate and create food 
            //in random position, after it we will realize reaction snake on hit with food. And in
            //the end we will realize function where will be instriction that reaction will be
            //if snake hit her tail or hit wall.
            //draw the frame with class wall
            Wall Frame = new Wall(80, 25, '+');
            Frame.Draw();
            //realize snake with help of class point
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();
            //create food in the window
            Food foods = new Food(80, 25, '$');
            Point food = foods.CreateFood();
            food.Draw();
            //start the game
            while (true)
            {
                //check on crash
                if (Wall.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                //check on operation Eat
                if (snake.Eat(food))
                {
                    food = foods.CreateFood();
                    food.Draw();
                }
                //pause
                Thread.Sleep(300);
                //check on press key
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }                
                snake.Move();
            }
            Console.ReadLine();
        }
    }
}
