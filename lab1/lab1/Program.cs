using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] arr = a.Split();
            int[] r = new int[arr.Length];
            for (int i=0; i < r.Length; i++)
            {
                r[i] = int.Parse(arr[i]);
            }
            int v = 0; 
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 2; j <= r[i]; j++)
                {
                    if (r[i] % j == 0)
                    {
                        v++;  
                    }
                }
                if (v == 1)
                {
                    Console.WriteLine(arr[i]);
                }
                v = 0;
            }
            Console.ReadKey();
        }
    }
}
