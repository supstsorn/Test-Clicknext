// See https://aka.ms/new-console-template for more information
using System;
using System.Linq.Expressions;
namespace demoSix;
class Program
{
    static void Main()
    {
        int[] num = new int[] {1, 2, 9, 4, 5, 8, 7, 6, 3, 10};
        int arr;
        //    Array.Sort(num); // ใช้sort

           for (int i = 0; i < num.Length; i++)
           {
            for (int n = i+1 ; n < num.Length; n++)
            {
                if(num[i] < num [n] ){
                    arr = num[i];
                    num[i] = num[n];
                    num[n] = arr;
                }
            }
           }

           foreach (int number in num)
            {
                Console.Write(number + " ");
            }
    }

}
