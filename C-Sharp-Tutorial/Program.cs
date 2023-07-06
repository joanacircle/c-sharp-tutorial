using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesBasics;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassBasics();
        }

        // Class
        public static void ClassBasics()
        {
            Human denis = new Human();
            denis.firstName = "Joana";
            denis.lastName = "Chang";
            denis.IntroduceMyself();

            Human Kevin = new Human();
            denis.firstName = "Kevin";
            denis.lastName = "La";
            denis.IntroduceMyself();

            Console.ReadKey();
        }

        // Loop
        public static void ForLoop()
        {
            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }

        public static void DoWhileLoop()
        {
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that was enough!" + wholeText);
            Console.Read();
        }

        public static void WhileLoop()
        {
            int counter = 0;
            string enterdText = "";
            while(enterdText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase by one and anything else" +
                    "+ enter if you want to finish counting");
                enterdText = Console.ReadLine();

                counter++;
                Console.WriteLine("Current people count is {0}", counter);
            }
            Console.WriteLine("{0} people are inside the bus. Press enter to close the program");
            Console.Read();
        }

        // -> Break & continue
        public static void BreakAndContinue()
        {
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if(counter == 8)
                {
                    Console.WriteLine("At 8 we stop!");
                    break;
                }else if(counter % 2 == 0)
                {
                    Console.WriteLine("Now comes an odd number!");
                }
            }
            Console.Read();
        }

        // If statement: shortcut
        public static void IfStatementShortcut()
        {
            int temperature = -5;
            string stateOfMatter;

            //if (temperature < 0)
            //    stateOfMatter = "solid";
            //else
            //    stateOfMatter = "liquid";

            // in short:
            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            //
            temperature += 110;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.ReadKey();
        }

        // Switch case
        public static void SwitchCase()
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            string username = "Denis";

            switch (username)
            {
                case "Denis":
                    Console.WriteLine("username is Denis");
                    break;
                case "root":
                    Console.WriteLine("username is root");
                    break;
                default:
                    Console.WriteLine("username is unknown");
                    break;
            }

            Console.Read();
        }

        // Nested if statement
        public static void NestedIfStatement()
        {
            bool isAdmin = false;
            bool isRegisterd = true;
            string username = "";
            Console.WriteLine("Please enter your usename");

            username = Console.ReadLine();
            if(isRegisterd && username != "" && username.Equals("admin"))
            {
                Console.WriteLine("Hi there, registerd user");
                Console.WriteLine("Hi there," + username);
                Console.WriteLine("Hi there, Admin");
            }

            if(isAdmin || isRegisterd)
            {
                Console.WriteLine("You are logged in");
            }

            Console.Read();
        }


        // If statement
        public static void IfStatement()
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnterANumber = int.TryParse(temperature, out number);

            if (userEnterANumber)
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value enterd was not number. 0 is as temperature");
            }

            if(numTemp < 10)
            {
                Console.WriteLine("Take the coat");
            }else if (numTemp == 20)
            {
                Console.WriteLine("Pants and pull over should be fine");
            }else if(numTemp > 30)
            {
                Console.WriteLine("It's super hot");
            }else
            {
                Console.WriteLine("Shorts are enough today");
            }

            Console.Read();
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

            Console.Read();
        }

        // Try and catch
        public static void TryAndCatch()
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divided by zero!");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number war too ling or too short for int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }

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