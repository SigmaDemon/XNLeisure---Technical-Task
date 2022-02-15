using System;

namespace xn_leisure_task
{
    class Program
    {
        static void Main(string[] args)
        {
            /* PROBLEM 1 */

            // This variable represents the string that will be used as input
            string sentence;
            // This variable represents the character input that will be counted within the sentence
            char charCount;
            // The count will start from 0
            int Count = 0;
            
            // This code allows the user to input their sentence
            Console.Write("Enter Your String: ");
            sentence = Console.ReadLine();

            // This code allows the user to select which character will be enumerated from the sentence
            Console.Write("Enter Count Character: ");
            charCount = Convert.ToChar(Console.ReadLine());

            // The for loop will provide the total number of characters when the 'if statement's condition is met'.
            Console.Write("Your Character Count: ");
            foreach (char chr in sentence)
            {
                if (chr == charCount)
                {
                    Count++;
                }
            }
            // The characters' total number is provided 
            Console.Write(Count);


            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();




            /* PROBLEM 2 */

            
            string number;
            int convertedNumber = 0;


            string trackedNumber;
            int convertedTrackedNumber = 0;


            int secondCount = 0;



            // This code allows the user to input their sentence
            Console.Write("Enter Your Long Number: ");
            number = Console.ReadLine();
            convertedNumber = (int)Convert.ToDouble(number);


           
            Console.Write("Enter The Number to Search: ");
            trackedNumber = Console.ReadLine();
            convertedTrackedNumber = Convert.ToInt32(trackedNumber);


            Console.Write("Your Character Count: ");
            foreach (int num in number)
            {
                int numConv;
                numConv = (int)Convert.ToDouble(num);
                if (num == convertedTrackedNumber)
                {
                    secondCount++;
                }
            }
            // The numbers' total number is provided 
            Console.Write(secondCount);


            Console.ReadLine();


            /* PROBLEM 3 */

            // This is the function call for the calculation function called 'AddNumbers'
            double additionResult = AddNumbers(7, 5);
            // The print statement provides the result between 7 and 5
            Console.Write("The Addition Result Between 7 and 5 is: " + additionResult);

            Console.ReadLine();

        }


        /* PROBLEM 3 */
        // This arrow function adds the two double variable numbers together into one result within the function call above after the arguments are provided
        public static double AddNumbers(double firstNumber, double secondNumber) => firstNumber + secondNumber;

    }
 }
