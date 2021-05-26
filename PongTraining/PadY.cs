using System;
using System.Collections.Generic;
using System.Text;

namespace PongTraining
{
    class PadY : Field
    {
        public PadY(int width, int length) : base(width, length) { }
        public override void MoveLogic(string[,] field)
        {
            GetYPadPosition(field);
            if (Console.ReadKey(true).Key == ConsoleKey.J && yPos < Width - 1)
            {
                field[yPos + 1, Length - 1] = "|y|";
                field[yPos, Length - 1] = "    ";
                yPos++;
                ConsoleClear(field);
            }
            else
            if (Console.ReadKey(true).Key == ConsoleKey.U && yPos > 0)
            {
                field[yPos - 1, Length - 1] = "|y|";
                field[yPos, Length - 1] = "    ";
                yPos--;
                ConsoleClear(field);
            }
            else
            {
                ConsoleClear(field);
            }
        }
    }
}
