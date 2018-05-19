using System;
using System.Collections.Generic;
using System.Text;

namespace Teleporters
{
   
    class Teleporter
    {
        private int[] position = new int[2];
        private LinkedList<Teleporter> links = new LinkedList<Teleporter>();

        public Teleporter(int[] position)
        {
            this.position[0] = position[0];
            this.position[1] = position[1];
        }

        public Teleporter(int x, int y)
        {
            this.position[0] = x;
            this.position[1] = y;
        }

        public void addLink(Teleporter tele)
        {
            links.AddLast(tele);
        }

        public string linkPrint()
        {
            StringBuilder sb = new StringBuilder();
            

            foreach (Teleporter t in links)
            {
                sb.Append(t + " ==> ");
            }

            return sb.ToString();
        }


        public override string ToString()
        {
            return (PositionX + "," + PositionY);
        }

        public int[] Position { get => position; set => position = value; }
        public int PositionX { get => position[0]; set => position[0] = value; }
        public int PositionY { get => position[1]; set => position[1] = value; }


    }
}
