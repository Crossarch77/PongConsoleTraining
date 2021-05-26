using System;
using System.Collections.Generic;
using System.Text;

namespace PongTraining
{
    class Field
    {
        protected int xPos;
        protected int yPos;
        protected int Width { get; set; }
        protected int Length { get; set; }
        public Field(int width, int length)
        {
            Width = width;
            Length = length;
        }
        public Field()
        {
            Width = 10;
            Length = 10;
        }

        public string[,] MakeField()
        {
            string[,] field = new string[Width, Length];
            for (int i = 0; i < Length; i++) 
            {
                for (int j = 0; j < Width; j++)
                {
                    field[i, j] = "   ";
                }
            }
            InitiatePads(field);
            InitiateBall(field);
            return field;
        }

        private void InitiatePads(string[,] field)
        {
            field[0, 0] = "|x|";
            field[0, Length - 1] = "|y|";
        }
        private void InitiateBall(string[,] field)
        {
            field[Width / 2, Length / 2] = "o";
        }
        public void Output(string[,] field)
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(field[i, j]);
                }
            }
        }

        protected void GetXPadPosition(string[,] field)
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (field[i,j] == "|x|")
                    {
                        xPos = i;
                        break;
                    }
                }
            }
        }
        protected void GetYPadPosition(string[,] field)
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (field[i, j] == "|y|")
                    {
                        yPos = i;
                        break;
                    }
                }
            }
        }

        public virtual void MoveLogic(string[,] field)
        {
            Console.WriteLine("Something went wrong that shouldn't be like this.");
        }

        protected void ConsoleClear(string[,] field)
        {
            Console.Clear();
            Output(field);
        }
    }
}
