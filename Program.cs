using System;


namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimeNumberFinder();
            string continueLooping = "";

            do
            {
                Console.Write("what number do you want to check for prime: ");
                string numToCheckText = Console.ReadLine();

                int numToCheck = int.Parse(numToCheckText);
                bool isPrime = CheckForPrime(numToCheck);

                if (isPrime)
                {
                    Console.WriteLine($"{numToCheck} is prime.");
                }
                else
                {
                    Console.WriteLine($"{numToCheck} is not prime.");
                }
                Console.WriteLine();
                Console.Write("Do you want to continue? (yes/no): ");
                continueLooping = Console.ReadLine();

            } while (continueLooping.ToLower() == "yes");

            Console.ReadLine();
        }

        /* public static void PrimeNumberFinder()
        {
            Console.WriteLine("Enter a number: ");

            int userInputNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 100; i++)
            {
                if (i % i == 0)
                {

                    Console.WriteLine($"prime {i}");
                }
                else
                {
                    Console.WriteLine($"not prime {i}");
                }


            }
        } */


        private static bool CheckForPrime(int num)
        {
            bool output = true;
            int max = num / 2;

            for (int i = 2; i < max; i++)
            {
                if(num % i == 0)
                {
                    output = false;
                    break;
                }
            }
            return output;
        }
    }
}
