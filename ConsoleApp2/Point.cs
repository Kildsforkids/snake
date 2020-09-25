using System;

namespace Figures
{
    class Point
    {
        int x;
        int y;
        char c;

        public Point(int x, int y, char c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }

        public void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

        public void Move(Direction direction)
        {
            Clear();
            switch (direction)
            {
                case Direction.Left: x--; break;
                case Direction.Right: x++; break;
                case Direction.Up: y--; break;
                case Direction.Down: y++; break;
            }
            Draw();
        }
    }
}
