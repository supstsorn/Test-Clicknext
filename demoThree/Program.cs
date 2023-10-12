// See https://aka.ms/new-console-template for more information
using System;
namespace demoThree;

class Program
{

    static void Main(string[] args)
    {
        int[] arrayA = {1 ,2 ,3 ,4 ,5 ,6 ,7 ,8 ,9 ,10};
        int[] arrayB = {1, 4, 6, 9, 10, 14, 16, 17};

        Console.WriteLine("A");
        Broadcast(arrayA);

        Console.WriteLine("B");
        Broadcast(arrayB);
    }
    static void Broadcast(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);

            if(i < array.Length -1 )
            {

                if(array[i+1] - array[i] == 1 )
                {
                    Console.Write("-");
                }else
                {
                    Console.Write(",");
                }
            }
         }

        Console.WriteLine();
    }
        
}
