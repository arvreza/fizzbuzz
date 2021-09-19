using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator();
            generator.Generate();
            Console.WriteLine("Hello World!");
        }
    }
}
