using System;

    public class EligibleToVote
    {
        public int Age;

        public void GetAge()
        {
            Console.Write("Enter your age: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }

        public void CheckEligibility()
        {
            if (Age >= 18)
            {
                Console.WriteLine(" You are eligible to vote.");
            }
            else
            {
                Console.WriteLine(" You are not eligible to vote.");
            }
        }
    }