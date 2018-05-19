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

        public int distance(Teleporter tele1, Teleporter tele2)
        {
            int xComp = (tele2.PositionX - tele1.PositionX);
            int yComp = (tele2.PositionY - tele1.PositionY);

            int distance = (xComp * xComp) + (yComp * yComp);

            return distance;
        }

        public void addLink(Teleporter tele)
        {
            foreach(Teleporter t in graph)
            {
               if(t.PositionX != tele.PositionX && t.PositionY != tele.PositionY)
                {
                    if (distance(t, tele) <= (radius * radius))
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

                Console.WriteLine(counter + ")" + "Teleporter: " + t + " links  " + t.linkPrint());

            }
        }

    }
}
