using System;

namespace Hokemon_U
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to HokeWorld!");
        }
    }
}
Hokemon hokeObject01 = new Hokemon();

Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);
