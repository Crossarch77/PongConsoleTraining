using System;
using System.Collections.Generic;
using System.Text;

namespace PongTraining
{
    class PadX : Field
    {
        public PadX(int width, int length) : base(width, length) { }
        public override void MoveLogic(string[,] field)
        {
            GetXPadPosition(field);
            if (Console.ReadKey(true).Key == ConsoleKey.S && xPos < Width - 1)
            {
                field[xPos + 1, 0] = "|x|";
                field[xPos, 0] = "   ";
                xPos++;
                ConsoleClear(field);
            }
            else
            if (Console.ReadKey(true).Key == ConsoleKey.W && xPos > 0)
            {
                field[xPos - 1, 0] = "|x|";
                field[xPos, 0] = "   ";
                xPos--;
                ConsoleClear(field);
            }
            else
            {
                ConsoleClear(field);
            }
        }
    }
}
