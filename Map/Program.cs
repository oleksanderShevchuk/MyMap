using System;

namespace Map
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(new Item<int, string>(1, "One"));
            myDictionary.Add(new Item<int, string>(2, "Two"));
            myDictionary.Add(new Item<int, string>(3, "Three"));
            myDictionary.Add(new Item<int, string>(4, "Four"));
            myDictionary.Add(new Item<int, string>(5, "Five"));
            myDictionary.Add(new Item<int, string>(101, "One hundred"));

            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myDictionary.Search(7) ?? "No found");
            Console.WriteLine(myDictionary.Search(3) ?? "No found");
            Console.WriteLine(myDictionary.Search(101) ?? "No found");

            myDictionary.Remove(3);
            myDictionary.Remove(1);
            myDictionary.Remove(101);

            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine();
            var easyMap = new EasyMap<int, string>();
            easyMap.Add(new Item<int, string>(1, "One"));
            easyMap.Add(new Item<int, string>(2, "Two"));
            easyMap.Add(new Item<int, string>(3, "Three"));
            easyMap.Add(new Item<int, string>(4, "Four"));
            easyMap.Add(new Item<int, string>(5, "Five"));

            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(easyMap.Search(7) ?? "No found");
            Console.WriteLine(easyMap.Search(3) ?? "No found");

            easyMap.Remove(3);
            easyMap.Remove(1);

            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            }

        }
    }
}
