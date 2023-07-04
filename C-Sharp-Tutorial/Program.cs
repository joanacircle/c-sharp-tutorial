using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result is: " + Caculate());
            Console.Read();
        }

        // User input
        public static int Caculate()
        {
            Console.WriteLine("Please enter the first number");
            string num1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string num2Input = Console.ReadLine();

            int num1 = int.Parse(num1Input);
            int num2 = int.Parse(num2Input);

            int result = num1 + num2;
            return result;
        }

        // Method: return value
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}