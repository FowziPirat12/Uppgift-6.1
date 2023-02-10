using System;
namespace Övning_6._1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in tre olika tal:");
            int tal1 = int.Parse(Console.ReadLine());
            
            int tal2 = int.Parse(Console.ReadLine());
            int tal3 = int.Parse(Console.ReadLine());
            Addera(tal1, tal2, tal3);
            
        }

        static void Addera(int tal1, int tal2, int tal3)
        {
            Console.WriteLine();
            Console.WriteLine("Summan av talen blir:");
            Console.WriteLine(tal1 + tal2 + tal3);
        }
    }
}