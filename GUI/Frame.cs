using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.GUI
{
    class Frame : GuiObject
    {
        private char _renderChar;

        public Frame(int x, int y, int width, int height, char renderChar) : base(x, y, width, height)
        {
            _renderChar = renderChar;
        }

        public override void Render()
        {
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                if (i == 0 || i == Height - 1)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write(_renderChar);
                    }
                }
                else
                {
                    Console.Write(_renderChar);
                    for (int j = 0; j < Width - 2; j++)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(_renderChar);
                }
            }
        }
    }
}
