using System;
using System.Threading;

namespace PongTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        static void Run()
        {
            Console.WriteLine("Input the board dimensions. Length then width. The minimum allowed is 10.");
            int len = int.Parse(Console.ReadLine());
            int wid = int.Parse(Console.ReadLine());
            if (len < 10 || wid < 10)
            {
                Environment.Exit(0);
            }
            Field field = new Field(len, wid);
            PadX px = new PadX(len, wid);
            PadY py = new PadY(len, wid);
            Ball ball = new Ball(len, wid);
            string[,] playfield = field.MakeField();
            field.Output(playfield);
            while (true)
            {
                px.MoveLogic(playfield);
                py.MoveLogic(playfield);
                ball.MoveLogic(playfield);
            }
        }
    }
}
