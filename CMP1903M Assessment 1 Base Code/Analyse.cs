using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            
            
            //Initialise all the values in the list to '0'
            
            
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }


            foreach (char a in input)
            {
                if (a.ToString() == "*")
                {
                    break;
                }
            

                
                bool Lower_or_Uppercase = "abcdefghijklmnopqrstuvwxyz".IndexOf(a) >= 0;
                if (Lower_or_Uppercase)
                {
                    values[4] += 1;
                }
                else if (a.ToString() != " " && a.ToString() != ".")
                {
                    values[3] += 1;
                }



                bool Consonant_or_Vowel = "aeiouAEIOU".IndexOf(a) >= 0;
                if (Consonant_or_Vowel)
                {
                    values[2] += 1;
                }
                else if (a.ToString() != " " && a.ToString() != ".")
                {
                    values[1] += 1;
                } 




                bool Sentences = input.IndexOf(".") >= 0;
                if (a.ToString() == ".")
                {
                    values[0] += 1;
                }
                if (Sentences == false)
                {
                    values[0] == 1;
                }   
            }

            return values;
        }
    }
}