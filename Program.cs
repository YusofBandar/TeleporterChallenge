using System;

namespace Teleporters
{
    class Program
    {
        static void Main(string[] args)
        {
            TeleporterGraph test1 = new TeleporterGraph(1);
            Teleporter _1 = new Teleporter(new Point(1, 1));
            Teleporter _2 = new Teleporter(new Point(2, 2));
            Teleporter _3 = new Teleporter(new Point(5, 5));
            Teleporter _4 = new Teleporter(new Point(3, 3));
            Teleporter _5 = new Teleporter(new Point(6, 7));

            test1.addTeleporter(_1);
            test1.addTeleporter(_2);
            test1.addTeleporter(_3);
            test1.addTeleporter(_4);
            test1.addTeleporter(_5);
            test1.PrintGraph();
            Console.ReadKey();
        }
    }
}
