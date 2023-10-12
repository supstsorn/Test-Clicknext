// See https://aka.ms/new-console-template for more information

using System;
using System.Linq.Expressions;
namespace demoNine;
class Program
{
    static string ReverseWords (string str)
    {
        string a = "";
        foreach (char item in str)
        {
            a = item + a;
        }
        return a;
    }
    static void Main(string[] args){
        string reverse = ReverseWords("Welcome to clicknext");
        Console.WriteLine(reverse);
    }

}
