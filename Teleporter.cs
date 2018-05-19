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
            return (Position.ToString());
        }
    }
}
