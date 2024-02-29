using System;
using Library;

namespace ConsoleApp;

class Program
{
    public static Drug drug = new Drug{
        Name = "Paracetamol",
        Price = "10"
    };
    public static void Main(string[] args)
    {
        Console.WriteLine(drug.Name);
    }
}
