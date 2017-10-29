using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSample
{
    class Program
    {
        static void Main(string[] args)
        {
            TestIntQueue();

            TestPersonQueue();
            Console.ReadKey();
        }

        public static void TestIntQueue()
        {
            Queue<int> intQueue = new Queue<int>(10);
            intQueue.Enque(1);
            intQueue.Enque(2);
            intQueue.Enque(3);
            intQueue.Enque(4);
            intQueue.Enque(5);

            Console.WriteLine("toList extension: ");
            var listOfQueue = intQueue.ToList();
            listOfQueue.ForEach(elem => Console.Write($"{elem}, "));

            Console.Write("\n");
            Console.WriteLine("Queue:");
            Console.WriteLine(intQueue.Dequeue());
            Console.WriteLine(intQueue.Dequeue());
            Console.WriteLine(intQueue.Dequeue());
        }

        public static void TestPersonQueue()
        {
            Queue<Person> peronQueue = new Queue<Person>(10);
            peronQueue.Enque(new Person(){Name = "Anna"});
            peronQueue.Enque(new Person() { Name = "Barbara" });
            peronQueue.Enque(new Person() { Name = "Cecylia" });

            peronQueue.Enque(new Person() { Name = "Dominika" });
            peronQueue.Enque(new Person() { Name = "Ewa" });

            Console.WriteLine("PersonQueue: ");
            Console.WriteLine("toList extension: ");
            var listOfQueue = peronQueue.ToList();
            listOfQueue.ForEach(elem => Console.Write($"{elem.Name}, "));

            Console.Write("\n");
            Console.WriteLine("Queue:");
            Console.WriteLine(peronQueue.Dequeue().Name);
            Console.WriteLine(peronQueue.Dequeue().Name);
            Console.WriteLine(peronQueue.Dequeue().Name);
        }
    }
}
