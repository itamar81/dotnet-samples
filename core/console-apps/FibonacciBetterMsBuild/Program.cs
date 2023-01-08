using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new FibonacciGenerator();
            foreach (var digit in generator.Generate(20))
            {
                Console.WriteLine(digit);
            }
        }
    }
}
