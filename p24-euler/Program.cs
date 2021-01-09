using System;
using System.Collections.Generic;


namespace p24_euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculation started");

            Permutations permu = new Permutations(new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'});


            String answer_p24 = "";


            Console.WriteLine("The answer to problem 24 of project Euler is " + answer_p24 + ".");
        }
    }
}
