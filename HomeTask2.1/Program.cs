using System;

namespace HomeTask2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] odd = { 1, 3, 5, 7, 9 };
            int[] even = { 2, 4, 6, 8, 10 };
            int sum = 0;
            for (int i = 0; i < odd.Length; i++)
            {
                Console.WriteLine(odd[i]);
                sum += odd[i];
                
            }
            Console.WriteLine("sum of oddnumber: "+sum);
            Console.WriteLine("---------------------------");
            for (int a = 0; a < even.Length; a++)
            {
                Console.WriteLine(even[a]);
            }
        }
    }
}
