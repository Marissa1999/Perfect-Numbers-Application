//ID: 1775227
//Name: Marissa Goncalves
//Assignment 2 - Problem 1: Perfect Numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{

    class PerfectNumbersTest
    {

        static void Main(string[] args)
        {

            //Create an PerfectNumbers object in order to call the Perfect(int value) method.
            var numberObject = new PerfectNumbers();

            //For every number between 2 and 10000,
            for(var value = 2; value <= 10000; value++)
            {
                //Call the Perfect(int value) method to determine whether the number is perfect or not.
                numberObject.Perfect(value);
            }


        }

    }

}
