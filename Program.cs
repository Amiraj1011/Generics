using System;

namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int output = Generic.MaxNumber(07, 01, 03);
            Console.WriteLine("{0} is maximum number ", output);
            Console.ReadLine();

        }
    }
}

