﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// author: nick terry
// date: apr 25, 2018

// this program  has three parts. Part one creates a cipher that takes a user input string, converts it to unicode, adds a constant
// number and converts it back to ascii. The second part takes that input adds values that are represented as a word and returns the
// ascii value. The third part uses the sample word and itself as the unicode to add to itself and return the resulting ascii values. 
// I wanted to use all unicode characters in the code but the instructions were to only use uppercase letters.

namespace ex10_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            // these are all to sample the program using all three methods
            Console.WriteLine("Please insert a string that consists of upper letters only");
            string input = Console.ReadLine();
            Console.WriteLine(Encrypt1(input));
            Console.WriteLine(Encrypt2(input));
            Console.WriteLine(Encrypt3(input));
            Console.ReadLine();
        }

        public static string Encrypt1(string input)
        {
            // this method is just in case the user doesnt follow the initial instructions
            input = input.ToUpper();
            StringBuilder result = new StringBuilder();
            foreach (char letter in input)
            {
                // converting each char into its unicode and adding 3 to it
                int temp = (int)letter;
                temp += 3;

                // The characters need to wrap and the last capitol letter 'Z' is unicode 90
                if (temp > 90)
                {
                    temp -= 26;
                }

                // converting the unicode back to char
                result.Insert(result.Length, (char)temp);
            }            
            return result.ToString();
        }

        public static string Encrypt2(string input)
        {
            int index = input.Length;

            // using the unicode values for "CAT" instead of three
            string cipher = "CAT";
            input = input.ToUpper();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                int temp = (int)input[i];

                // modulating i by the cipher length to make sure it stays within the bounds of the cipher string
                temp += (int)cipher[i % cipher.Length] - 60;
                if (temp > 90)
                {
                    temp -= 26;
                }
                result.Insert(result.Length, (char)temp);
            }
            return result.ToString();
        }

        public static string Encrypt3(string input)
        {
            int index = input.Length;
            input = input.ToUpper();

            // concatinating the input with hardcoded "CAT". The only change from the second encryption method
            string cipher = "CAT" + input;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                int temp = (int)input[i];
                temp += (int)cipher[i % cipher.Length] - 60;
                if (temp > 90)
                {
                    temp -= 26;
                }
                result.Insert(result.Length, (char)temp);
            }
            return result.ToString();
        }
    }
}
