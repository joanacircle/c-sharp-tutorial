using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Operators();
        }

        // Operators
        public static void Operators()
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //   unary operator
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny {0}", !isSunny);

            // increment operator
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num); // 1
            Console.WriteLine("num is {0}", num++); // 1
            // pre increment
            Console.WriteLine("num is {0}", ++num); // 3

            //decrement opertor
            num--;
            Console.WriteLine("num is {0}", num); // 2
            Console.WriteLine("num is {0}", num--); // 2
            // pre increment
            Console.WriteLine("num is {0}", --num); // 0

            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            // equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            // condtional operator
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);



            Console.ReadKey();
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