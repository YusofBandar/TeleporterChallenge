using System;
using System.Collections.Generic;
using System.Text;

namespace Teleporters
{
    class TeleporterGraph
    {
        private LinkedList<Teleporter> graph = new LinkedList<Teleporter>();
        private int radius;
        public TeleporterGraph(int radius)
        {
            this.radius = radius;
        }

        public void addTeleporter(Teleporter tele)
        {
            graph.AddLast(tele);
            addLink(tele);
        }

        public bool Teleportation(Point start, Point end)
        {
            Teleporter tele1 = null;
            Teleporter tele2 = null;
            foreach(Teleporter t in graph)
            {
                if(t.Position.distance(start) <= (radius * radius))
                {
                    tele1 = t;
                    if(tele2 != null)
                    {
                        break;
                    }
                }

                if(t.Position.distance(end) <= (radius * radius))
                {
                    tele2 = t;
                    if(tele1 != null)
                    {
                        break;
                    }
                }
            }

            if(tele1 != null && tele2 != null)
            {
                return false;
            }

            return checkLink(tele1, tele2);
        }

        private bool checkLink(Teleporter tele1, Teleporter tele2)
        {
            bool found = false;
            foreach(Teleporter t in tele1.Links)
            {
                if (t.Compare(tele2))
                {
                    found = true;
                    break;
                }

                found = checkLink(t, tele2);
            }

            return found;
        }
        

        private void addLink(Teleporter tele)
        {
            foreach(Teleporter t in graph)
            {
                if(t.Compare(tele))
                {
                    if(t.Position.distance(tele.Position) <= (radius * radius))
                    {
                        tele.addLink(t);
                        t.addLink(tele);
                    }
                }
                
            }
        }

        

        public void PrintGraph()
        {
            int counter = 0;
            foreach(Teleporter t in graph)
            {

                Console.WriteLine(counter + ") " + "Teleporter: " + t + " links  " + t.linkPrint());
                counter++;
            }
        }

    }
}
