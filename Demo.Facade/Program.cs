using System;
using System.Collections.Generic;

namespace Demo.Facade
{
    class Program
    {
        public static IEnumerable<int> GetDump()
        {
            for(int i = 0; i < 8; i++)
            {
                var something =i;
                yield return something;
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string request = Console.ReadLine();

                switch (request.ToLower())
                {
                    case "clean":
                        Console.Clear();
                        break;
                    case "manual":
                        ManualForEach(GetDump());
                        break;
                    case "default":
                        DefaultForEach(GetDump());
                        break;
                    default:
                        Console.WriteLine("Unknown request");
                        break;
                }
            }
        }


        public static void ManualForEach( IEnumerable<int> list)
        {
            var enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.ToString());
            };
        }

        public static void DefaultForEach(IEnumerable<int> list)
        {
            foreach(var element in list)
            {
                Console.WriteLine(element.ToString());
            }
        }
    }
}
