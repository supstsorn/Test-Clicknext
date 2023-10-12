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
        int sloop;

        for (int i = 1; i <= Loop; i++)
        {
            sloop = Loop-i;
            
            for(s = 1; s <= sloop; s++ ){
                Console.Write(" ");
            }
            for(s = 1; s <= Loop-sloop; s++){
                Console.Write("*", s);
            }         
            for(s = Loop-sloop-1; s >= 1; s--){
                Console.Write("*", s);

        }
            Console.Write("\n");
        }
      Console.WriteLine();    
    }
  }
}

// https://www.comscidev.com/271-%E0%B9%82%E0%B8%84%E0%B9%89%E0%B8%94-c-number-triangle%E0%B8%94%E0%B9%89%E0%B8%A7%E0%B8%A2%E0%B8%A5%E0%B8%B9%E0%B8%9B-for/