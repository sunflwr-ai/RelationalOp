/* Check if a user is eligible to vote (age >= 18) */
using System;
    public class Comparision
    {
        public int num1, num2;

        public void GetNumbers()
        {
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        public void CompareNumbers()
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"{num2} is greater than {num1}");
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }
        }
    }

 
