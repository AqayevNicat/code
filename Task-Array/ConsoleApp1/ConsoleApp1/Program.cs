using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] arr2 = new int[10];
            //for (int i = arr1.Length - 1; i >=0; i--)
            //{
            //    arr2[arr1.Length-1-i] = arr1[i];
            //}
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}

            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 6,7,8,9,10 };

            int i;
            int[] arrcon = new int[0];

            for ( i = 0; i < array1.Length + array2.Length; i++)
            {
            }
            Array.Resize(ref arrcon, arrcon.Length + i);
        }
    }
}
