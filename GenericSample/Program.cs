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
            TestExtensionMethod();
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

            Console.Write("\n");
            Console.WriteLine("Queue:");
            Console.WriteLine(intQueue.Dequeue());
            Console.WriteLine(intQueue.Dequeue());
            Console.WriteLine(intQueue.Dequeue());
        }

        public static void TestPersonQueue()
        {
            Queue<Person> personQueue = new Queue<Person>(10);
            personQueue.Enque(new Person(){Name = "Ann"});
            personQueue.Enque(new Person() { Name = "Bernard" });
            personQueue.Enque(new Person() { Name = "Christopher" });

            personQueue.Enque(new Person() { Name = "Donny" });
            personQueue.Enque(new Person() { Name = "Elizabeth" });

            Console.Write("\n");
            Console.WriteLine("Queue:");
            Console.WriteLine(personQueue.Dequeue().Name);
            Console.WriteLine(personQueue.Dequeue().Name);
            Console.WriteLine(personQueue.Dequeue().Name);
        }

        public static void TestExtensionMethod()
        {
            Console.WriteLine("ToQueue method");
            List<int> list = new List<int>(){2, 3, 5, 7};
            var queue = list.ToQueue();
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
