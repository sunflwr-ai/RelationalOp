using System;
public class Program
{
    static void Main(string[] args)
    {

        EligibleToVote vote = new EligibleToVote();
        vote.GetAge();
        vote.CheckEligibility();

        Comparision c = new Comparision();
        c.GetNumbers();
        c.CompareNumbers();
    }
}