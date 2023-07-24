using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Hello World
            Console.WriteLine("Hello, World!");





           // Task 2: Variables and User Input

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");







            //Task 3: Basic Arithmetic

            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");

            if (num2 != 0)
            {
                double division = (double)num1 / num2;
                double modulus = num1 % num2;

                Console.WriteLine($"Division: {division}");
                Console.WriteLine($"Modulus: {modulus}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }






            //Task 4: Control Structures

            Console.WriteLine("Enter an integer:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }







            //Task 5: Loops

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }






            //Task 6: Arrays

            int[] numbers = { 5, 10, 15, 20, 25 };

            int Sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");






            //Task 7: Methods


            Console.WriteLine("Enter an integer to calculate its factorial:");
            int no = Convert.ToInt32(Console.ReadLine());

            long factorial = CalculateFactorial(no);

            Console.WriteLine($"Factorial of {no} is {factorial}");
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * CalculateFactorial(n - 1);
        }







        //Task 8: Exception Handling


        

          

    }
}

