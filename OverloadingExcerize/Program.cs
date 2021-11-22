using System;

namespace OverloadingExcerize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            var userIntOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integer: ");
            var userIntTwo = Convert.ToInt32(Console.ReadLine());

            var intAnswer = Add(userIntOne, userIntTwo);

            Console.WriteLine("Enter a decimal number: ");
            var userDecOne = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter another decimal number: ");
            var userDecTwo = Convert.ToDecimal(Console.ReadLine());

            var decAnswer = Add(userDecOne, userDecTwo);

            Console.WriteLine("Enter another integer: ");
            var userDataA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter one last integer: ");
            var userDataB = Convert.ToInt32(Console.ReadLine());

            var lastAnswer = Add(userDataA, userDataB, true);

            Console.WriteLine("\n===============================================");
            Console.WriteLine($"Int Add: {intAnswer}");
            Console.WriteLine($"Decimal Add: {decAnswer}");
            Console.WriteLine(lastAnswer);
            Console.WriteLine("===============================================");
        }

        // Create an Add method:
        //  This Add method takes 2 integer parameters
        static int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        // Create an overload of the Add method:
        //  This Add method needs to have 2 decimal parameters
        static decimal Add(decimal numberOne, decimal numberTwo)
        {
            return numberOne + numberTwo;
        }

        // Create another overload of the Add method:
        //  This Add method returns a string
        static string Add(int numberOne, int numberTwo, bool isTrue) // And this Add mthod takes 3 parameters; 2 integer parameters, 1 boolean parameter
        {
            // If the boolean parameter is equal to true
            //  This Add method will return the sum of the 2 numbers
            //  This Add method adds the word "dollars" at the end of the string if the total is equal to any other amount

            var total = numberOne + numberTwo;

            if (isTrue == true && total > 1)
            {
                return $"${total} dollars";
            }
            else if (isTrue == true && total == 1)
            {
                return $"${total} dollars";
            }
            else if (isTrue == true && total < 1)
            {
                return $"${total} dollars";
            }
            else
            {
                return total.ToString();
            }

        }

    }

}
