using System;
using System.Collections.Generic;
using System.Text;

namespace Teleporters
{
    class Point
    {
        int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(int [] point)
        {
            x = point[0];
            y = point[1];
        }

        public override string ToString()
        {
            return (x + "," + y);
        }

        public int[] Position { get => new int[] { x, y };}
        public int X { get => x; }
        public int Y { get => y; }

        public int distance(Point point)
        {
            int xComp = (x - point.x);
            int yComp = (y - point.y);

            int distance = (xComp * xComp) + (yComp * yComp);

            return distance;
        }
    }
}
