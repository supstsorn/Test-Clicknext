// See https://aka.ms/new-console-template for more information
using System;
namespace demoTwo;
class Program
{
    static void Main(string[] args)
    {
        string WordOne = "Mary";
        string WordTwo = "army";

        // string WordOne = "Maryy";
        // string WordTwo = "Armyy";

        // string WordOne = "Maryy";
        // string WordTwo = "Army";

        // string WordOne = "Marym";
        // string WordTwo = "Armyy";

        bool CountWord = WordOne.Length == WordTwo.Length;
        Console.WriteLine(CountWord);
    }
}
