using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();
            eventManager.AddEventHandler(Event1);
            eventManager.AddEventHandler(Event2);

            Console.WriteLine("Event triggered:");
            eventManager.TriggerEvent();

            eventManager.RemoveEventHandler(Event1);

            Console.WriteLine("\n after removing  handler:");
            eventManager.TriggerEvent();

        }

        private static void Event1()
        {
            Console.WriteLine("Event1 invoked");
        }

        private static void Event2()
        {
            Console.WriteLine("Event2 invoked");
        }
    }
}
