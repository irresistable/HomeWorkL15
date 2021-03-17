using System;

namespace HomeWorkL15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("L 1.5");
            bool a = true, b = false, c = false;
            Console.WriteLine(a | b & !c);
            Console.WriteLine($"\n{!a & !b}");
            Console.WriteLine($"\n{!(a & c) | b}");
            Console.WriteLine($"\n{a & !b | c}");
            Console.WriteLine($"\n{a | (!(b & c))}");

            Console.WriteLine("\n\nL 1.6");
            bool x = false, y = false, z = true;
            Console.WriteLine(x | y & !z);
            Console.WriteLine($"\n{!x & !y}");
            Console.WriteLine($"\n{!(x & z) | y}");
            Console.WriteLine($"\n{x & !y | z}");
            Console.WriteLine($"\n{x & (!y | z)}");
            Console.WriteLine($"\n{x | (!(y | z))}");

            Console.WriteLine("\n\nL 1.7");
            a = true; b = false; c= false; 
            Console.WriteLine(a | !(a & b) | c);
            Console.WriteLine($"\n{!a | a & (b | c)}");
            Console.WriteLine($"\n{(a | b & !c) & c}");

        }
    }
}
