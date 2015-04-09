using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inClassSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();    
        }

        static string AnNoYiNgTeXtIfYeR(string notAnnoyingString) 
        {
            //input: "nickleback"
            //output: "NiCkLeBaCk"
            //delare a return string for output
            string returnString = string.Empty;
            //looping over every letter
            for (int i = 0; i < notAnnoyingString.Length; i++)
            {
                string letter = notAnnoyingString[i].ToString();
                if (i % 2 == 0 )
                {
                    returnString = returnString + letter.ToUpper();

                }
                else
                {
                    returnString += letter.ToLower();
                }
            }

            //get a letter to examine
            //see if the position of the letter is odd or even
                //even make it capital

                //odd, make that sucka small

            //loop finished, return the return string
            return returnString;
            
        }
        
        
        static int NumberRounder(int numberToRound) 
        {
            int returnNumber = 0;
            int remainder = numberToRound % 5; 
            if (numberToRound % 5 > 2)
            {
                return numberToRound 
            }
        }
    
    }
}
