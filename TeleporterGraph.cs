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

        

        private void addLink(Teleporter tele)
        {
            foreach(Teleporter t in graph)
            {
                if(t.Position.X != tele.Position.X && t.Position.Y != tele.Position.Y)
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
