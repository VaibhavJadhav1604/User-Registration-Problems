using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace URP3
{
    internal class URP3
    {
        //writing the expression as we are needed
        public static string reg = "^[a-z]{3}[1-9]{2}[.][a-z]{3}[1-9]{2}@[a-z]{2}[.][a-z]{2}[.][a-z]{2}";
        public static bool validate(string word)
        {
            //return true if the word matches the regex
            return Regex.IsMatch(word, reg);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter The Email:");
            String email = Console.ReadLine();

            if (validate(email))
            {
                Console.WriteLine("Valid Data");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        }
    }
}
