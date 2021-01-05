//ID: 1775227
//Name: Marissa Goncalves
//Assignment 2 - Problem 1: Perfect Numbers

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{

    class PerfectNumbers
    {
      
        public void Perfect(int number)
        {

            //Set sum of perfect integers to 0.
            int perfectSum = 0;

            //Create a new array list to store factors.
            ArrayList factorArray = new ArrayList();

            //For every factor, less than the actual number,
            for (var factor = 1; factor <= number / 2; factor++)
            {
                //If the remainder of the number and its factor is 0,
                if (number % factor == 0)
                {
                    //Add the factor to the sum of the specific.
                    perfectSum += factor;

                    //Add the factor to the array list.
                    factorArray.Add(factor);
                }
            }


            //If the number is equal to the sum of its factors,
            if (number == perfectSum)
            {
                
                //Print the one of the perfect numbers.
                Console.WriteLine($"The Perfect Number is {number}.");

                //Print the subtitle indicating the perfect number's factor.
                Console.Write($"Factors:");

                //Print every factor stored in the array.
                foreach (var element in factorArray)
                {
                    //Print the factor element.
                    Console.Write($" {element} ");
                }

                //Skip a line.
                Console.WriteLine($"");

                //Skip a line.
                Console.WriteLine($"");

            }

            
        }


    }
}
