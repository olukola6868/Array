using System;

namespace ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
           Console.WriteLine("ENter the length of the array");
           int length = int.Parse(Console.ReadLine());
           int[]array = new int[length];
           Console.WriteLine("Enter the sorted array number");
           int number = int.Parse(Console.ReadLine());
           for(int i =0;i<array.Length;i++)
           {
               Console.WriteLine("Enter your number");
               array[i] = int.Parse(Console.ReadLine());
           }
           for(int i = 1;i < array.Length;i++)
           {
               if(array[i] == number)
               {
                   Console.WriteLine("The number is available");
               }
               else
               {
                   Console.WriteLine(-1);
               }
           }


        }
    }
}
