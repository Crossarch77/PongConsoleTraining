using System;
using System.Collections.Generic;
using System.Text;

namespace PongTraining
{
    class Ball : Field
    {
        int ballX;
        int ballY;
        Random rand = new Random();
        int randomHolder;
        public Ball(int width, int length) : base(width, length) { }
        public override void MoveLogic(string[,] field)
        {
            int i;
            int j;
            randomHolder = rand.Next(1, 3);
            if (randomHolder == 1)
            {
                StartMovingLeft(field);
                i = ballY;
                j = ballX;
                while(i < Length && j < Width && i >= 0 && j >= 0)
                {
                    if (j == 0 || j == Width-1)
                    {
                        Console.WriteLine("Game over.");
                    }
                    LeftTop(field);
                }
            }
            else
            {
                StartMovingRight(field);
            }

        }

        private void StartMovingRight(string[,] field)
        {
            field[Width / 2 + 1, Length / 2 + 1] = "o";
            field[Width / 2, Length / 2] = "   ";
            ballY = Width / 2 + 1;
            ballX = Length / 2 + 1;
        }
        private void StartMovingLeft(string[,] field)
        {
            field[Width / 2 - 1, Length / 2 - 1] = "o";
            field[Width / 2, Length / 2] = "   ";
            ballY = Width / 2 - 1;
            ballX = Length / 2 - 1;
        }

        private void RightBot(string[,] field)
        {
            field[ballY, ballX] = "   ";
            field[ballY + 1, ballX + 1] = "o";
            ballX++;
            ballY++;
            ConsoleClear(field);
        }
        private void LeftTop(string[,] field)
        {
            field[ballY, ballX] = "   ";
            field[ballY - 1, ballX - 1] = "o";
            ballX--;
            ballY--;
            ConsoleClear(field);
        }
        private void RightTop(string[,] field)
        {
            field[ballY, ballX] = "   ";
            field[ballY - 1, ballX + 1] = "o";
            ballX++;
            ballY--;
            ConsoleClear(field);
        }
        private void LeftBot(string[,] field)
        {
            field[ballY, ballX] = "   ";
            field[ballY + 1, ballX - 1] = "o";
            ballX--;
            ballY++;
            ConsoleClear(field);
        }
    }
}
