using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace URP1
{
    internal class URP1
    {
        //writing the expression as we are needed
        public static string reg = "^[A-Z][A-za-z]{2,}";
        public static bool validate(string word)
        {
            //return true if the word matches the regex
            return Regex.IsMatch(word, reg);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter The First Name:");
            String fname = Console.ReadLine();

            if (validate(fname))
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