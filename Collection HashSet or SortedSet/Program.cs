using System;
using System.Collections.Generic;
namespace Collection_HashSet_or_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> obj = new HashSet<string>() { "akshay","saini" };
            foreach (string item in obj)
            {
                Console.WriteLine("Value : "+item);
            }
            HashSet<int> h = new HashSet<int>();
            h.Add(9);
            h.Add(990);
            foreach  (int item in h)
            {
                Console.WriteLine(item);
            }
          
            Console.WriteLine(h.Add(90));

            // SortedSet
            SortedSet<int> s = new SortedSet<int>() { 89, 90 };
            foreach (int item in s)
            {
                Console.WriteLine("Value : " + item);
            }
            Console.WriteLine();
            SortedSet<string> S = new SortedSet<string>();
            S.Add("akshay");
            S.Add("saini");

            foreach (string item in S)
            {
                Console.WriteLine("Value : " + item);
            }
        }
    }
}
