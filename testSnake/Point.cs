using System;

namespace testSnake
{
    public class Point
    {
        internal int x;
        internal int y;
        internal char sym;

        public Point()
        {

        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
