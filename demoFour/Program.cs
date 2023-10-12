// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace demoFour
{
  class Program
  {
    static void Main()
    {
        int Loop = 5;
        int s;

        for (int i = 1; i <= Loop; i++)
        {
            for(s = 1; s<= i; s++ ){
                Console.Write(" ");
            }
            for(s = 1; s <= (Loop-i)+1; s++){
                Console.Write("*", s);
            }         
            for(s = Loop-i; s >= 1; s--){
                Console.Write("*", s);
        }
            Console.Write("\n");
        }
      Console.WriteLine();    
    }
  }
}

// https://www.comscidev.com/997-c-number-triangle-upside-down/