using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}