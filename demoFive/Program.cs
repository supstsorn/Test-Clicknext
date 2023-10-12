// See https://aka.ms/new-console-template for more information
using System;

namespace demoFive
{
  class Program
  {
    static void Main()
    {
        int Loop = 4;
        int s;
        int number = 1;

        for (int i = 1; i <= Loop; i++)
        {
            for(s = 1; s<= i; s++ ){
                Console.Write(" ");
            }
            for(s = 1; s <= i; s++){
                Console.Write(number);
                number++;
            }         
            for(s = Loop-i; s >= 1; s--){
                Console.Write( "1" , s);
        }
            Console.Write("\n");
        }
      Console.WriteLine();    
    }
  }
}
