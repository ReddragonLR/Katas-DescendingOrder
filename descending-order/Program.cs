using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descending_order
{
    public static class Kata
    {
        public static long DescendingOrder(int num)
        {
            // Step 1 - Rule out negative numbers
            int positiveNumber = Math.Abs(num);

            if (positiveNumber == 0)
            {
                return positiveNumber;
            }

            // Step 2 - Determine number of digits in number
            int numberOfDigitsInNumber = (int)Math.Log10((double)positiveNumber) + 1;

            // Step 3 - Create array to hold numbers
            int[] digitsToSort = new int[numberOfDigitsInNumber];

            // Step 4 - Load numbers into array
            for (int i = 0; i < numberOfDigitsInNumber; i++)
            {
                digitsToSort[i] = positiveNumber % 10;
                positiveNumber = positiveNumber / 10; //its an int so the decimals will drop off
            }

            // Step 4 - Do the actual array sorting
            Array.Sort(digitsToSort);

            // Step 5 - Return to int
            long sortedNumber = 0;
            for (int i = 0; i < numberOfDigitsInNumber; i++)
            {
                sortedNumber = sortedNumber + (long)(digitsToSort[i] * Math.Pow(10, i));
            }

            return sortedNumber;
        }
    }
}
