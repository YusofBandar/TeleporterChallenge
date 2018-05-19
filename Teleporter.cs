using System;
using System.Collections.Generic;
using System.Text;

namespace Teleporters
{
   
    class Teleporter
    {
        
        private LinkedList<Teleporter> links = new LinkedList<Teleporter>();
        Point position;

        public Teleporter(Point position)
        {
            this.position = position;
        }

        internal Point Position { get => position; set => position = value; }
        internal LinkedList<Teleporter> Links { get => links; set => links = value; }

        public void addLink(Teleporter tele)
        {
            links.AddLast(tele);
        }

        public bool Compare(Teleporter tele)
        {
            if (Position.X != tele.Position.X && Position.Y != tele.Position.Y)
            {
                return true;
            }

            return false;
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
            return (Position.ToString());
        }
    }
}
