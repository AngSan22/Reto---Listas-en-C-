using System;

namespace list
{
    class program
    {
        static void Main(string[] args)
        {
            /*
            LinkedList team1 = new LinkedList();
            LinkedList team2 = new LinkedList();
            LinkedList team3 = new LinkedList();

            team1.addAtTail("Jesus");
            team1.addAtTail("Salomon");
            team1.addAtTail("Yael");

            team2.addAtFront("Cristian");
            team2.addAtFront("Daniel");
            team2.addAtFront("Diego");

            team3.addAtFront("Imelda");

            LinkedListIterator iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }
            Console.WriteLine();

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            team1.remove(0);
            team1.addAtFront("Rebeca");
            Console.WriteLine();
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes");

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            team2.remove(2);
            team2.addAtTail("Rita");
            Console.WriteLine();
            Console.WriteLine("Team 2 tiene: " + team2.getSize() + " integrantes");

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            team3.remove(0);
            team3.remove(0);

            team3.addAtTail("Tadeo");
            team3.addAtFront("Isai");

            Console.WriteLine();
            Console.WriteLine("Team 3 tiene: " + team3.getSize() + " integrantes");

            iterator = team3.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            if (team1.getAt(1).Equals("Salomon"))
            {
                team1.setAt(1, "Luis");
            }

            Console.WriteLine();
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes");

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }
            */

            ArrayList team1 = new ArrayList(2);
            ArrayList team2 = new ArrayList();
            ArrayList team3 = new ArrayList();

            team1.addAtTail("Jesus");
            team1.addAtTail("Salomon");
            team1.addAtTail("Yael");

            team2.addAtFront("Cristian");
            team2.addAtFront("Daniel");
            team2.addAtFront("Diego");

            team3.addAtFront("Imelda");

            ArrayListIterator iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }
            Console.WriteLine();

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            team1.remove(0);
            team1.addAtFront("Rebeca");
            Console.WriteLine();
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes");

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            team2.remove(2);
            team2.addAtTail("Rita");
            Console.WriteLine();
            Console.WriteLine("Team 2 tiene: " + team2.getSize() + " integrantes");

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            team3.remove(0);
            team3.remove(0);

            team3.addAtTail("Tadeo");
            team3.addAtFront("Isai");

            Console.WriteLine();
            Console.WriteLine("Team 3 tiene: " + team3.getSize() + " integrantes");

            iterator = team3.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            if (team1.getAt(1).Equals("Salomon"))
            {
                team1.setAt(1, "Luis");
            }

            Console.WriteLine();
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes");

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }
        }

    }
}