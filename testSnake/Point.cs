using System;

namespace testSnake
{
    public class Point
    {
        internal int x;
        internal int y;
        internal char sym;

        public Point() {}
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;


        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
