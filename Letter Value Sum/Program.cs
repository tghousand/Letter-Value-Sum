using System;
using System.Linq;
/****
 * Letter Value Sum
 * Calculates the sum of letters with 'A' equalling 1, acending until 'Z' equalling 26
 * Tyler Housand
 * 9/27/2022
 *****/
namespace Letter_Value_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            String userInput;
            int wordValue;
            Boolean acceptableInput;
            do
            {
                Console.Write("Input a word: ");
                userInput = Console.ReadLine();
                userInput = String.Concat(userInput.Where(c => !Char.IsWhiteSpace(c)));
                acceptableInput = checkWord(userInput);
            } while (acceptableInput == false);
            userInput = userInput.ToUpper();
            wordValue = addValue(userInput);
            Console.WriteLine(wordValue);
        }

        //checks for any non-letter characters
        public static bool checkWord (String userInput)
        {
            if (userInput.All(char.IsLetter))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please input only letters.");
                return false;
            }
        }

        //adds the value of each letter together
        public static int addValue(String userInput)
        {
            int wordValue = 0;
            for(int x = 0; x < userInput.Length; x++)
            {
                wordValue += userInput[x] - 64;
            }
            return wordValue;
        }
    }
}
