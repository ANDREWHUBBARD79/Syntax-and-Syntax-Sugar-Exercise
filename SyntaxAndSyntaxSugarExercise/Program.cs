﻿namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Given the following code, change the code to implement:
            //inferred typing
            //string interpolation
            //and the ternary operator
            //int answer = 4; //explicit typing
            //string response; // explicit typing

            //if (answer < 9)
            //{
            //    response = answer + "is less than nine";
            //}
            //else
            //{
            //    response = answer + "greater than or equal to nine";
            //}

            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than 9" : $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);





        }
    }
}
