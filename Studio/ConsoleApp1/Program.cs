using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void printCharFreq(string inputString)
        {

            System.Collections.Generic.Dictionary<char, double> charCout = new System.Collections.Generic.Dictionary<char, double>();
            
            char[] charactersInString = inputString.ToCharArray();

            for (int i = 0; i<charactersInString.Length; i++)
            {
                if (!charCout.ContainsKey(charactersInString[i]))
                {
                    charCout.Add(charactersInString[i], 1);
                }
                else
                {
                    charCout[charactersInString[i]] += 1;
                }
            }

            foreach(KeyValuePair<char,double> letter in charCout)
            {
                Console.WriteLine(letter.Key + ":" + letter.Value);
            }
        }
            
        static void Main(string[] args)
        {
            String inputStr = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            printCharFreq(inputStr);
        }
    }
}
