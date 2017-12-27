using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlecRecursionIntro
{
    class Program
    {
        static void repeat(int number, int max)
        {
            if (number < max)
            {
                Console.WriteLine(number);
                repeat(number + 1, max);
            }
        }

        static int multiply(int a, int b) //5,3
        {
            Console.WriteLine($"Entering function with values {a},{b}");
            if (b > 0)
            {
                int result = multiply(a, b - 1) + a;
                Console.WriteLine($"Returning {result}");
                return result;
            }
            else
            {
                Console.WriteLine("Returning 0");
                return 0;
            }
        }
        static int factorial(int n)
        {
            //int d = 1;
            //int c = a - 1;
            if (n > 1)
            {
                //int b = a * c;
                //a--;
                //c--;
                //int e = a * d;
                //factorial a;

                return n * factorial(n - 1);

                
            }
            else // n is equal to 1
            {
                return 1;
            }
        }
        static int Fibonacci(int a)
        {
            if(a>2)
            {
                return Fibonacci(a-1) + Fibonacci(a-2);
            }
            else
            {
                return 1;
            }
            
        }
        

        static void Main(string[] args)
        {
            //repeat(1,10);
            //Console.WriteLine($"Answer: {multiply(5, 3)}");  // 5,3
            int n = 5;
            int myNumber = Fibonacci(14);
            Console.WriteLine(myNumber.ToString());
            Console.WriteLine($"Factorial of {n} is {factorial(n)}");
            Console.ReadKey();
        }
    }
}
