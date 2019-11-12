using System;

namespace Demo.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var ourEvent = Mediator.GetInstance();
            ourEvent.customEvent += (object sender, EventArgs e) =>
            {
                Console.WriteLine("Hello from mighty observer 1");
            };
            ourEvent.customEvent += (object sender, EventArgs e) =>
            {
                Console.WriteLine("Hello from mighty observer 2");
            };

            while (true)
            {             
                string request = Console.ReadLine();

                switch (request.ToLower())
                {
                    case "clean":
                        Console.Clear();
                        break;
                    case "rise event":
                        ourEvent.OnEventRised();
                        break;
                    default:
                        Console.WriteLine("Unknown request");
                        break;
                }
            }
        }
    }
}
