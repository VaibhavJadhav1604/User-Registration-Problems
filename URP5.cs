using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace URP5
{
    internal class URP5
    {
        //writing the expression as we are needed
        public static string reg = "[A-Za-z1-9]{8}";
        public static bool validate(string word)
        {
            //return true if the word matches the regex
            return Regex.IsMatch(word, reg);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter The Password:");
            String pass = Console.ReadLine();

            if (validate(pass))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
