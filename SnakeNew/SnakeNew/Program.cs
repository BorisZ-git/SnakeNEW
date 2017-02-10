using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.ReadLine();
        }
    }
}
