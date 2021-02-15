using System;
using System.Collections.Generic;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("How many students for course A?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                A.Add(student);
            }

            Console.Write("How many students for course A?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                B.Add(student);
            }

            Console.Write("How many students for course A?");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                C.Add(student);
            }

            HashSet<int> all = new HashSet<int>(A);
            all.UnionWith(B);
            all.UnionWith(C);
            Console.WriteLine($"Total students: {all.Count}");
        }
    }
}
