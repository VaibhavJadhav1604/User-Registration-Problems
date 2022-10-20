using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace URP4
{
    internal class URP4
    {
        //writing the expression as we are needed
        public static string reg = "^[91]{2,2}[\\s][1-9]{10,10}";
        public static bool validate(string word)
        {
            //return true if the word matches the regex
            return Regex.IsMatch(word, reg);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter The Mobile Number:");
            String mob = Console.ReadLine();

            if (validate(mob))
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
