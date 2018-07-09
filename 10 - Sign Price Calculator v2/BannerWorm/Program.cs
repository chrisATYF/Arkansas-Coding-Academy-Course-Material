using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BannerWorm.Models;

namespace BannerWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BannerWorm! What would you like to create?");

            var signText = Console.ReadLine();
            var sign = new Sign
            {
                RawSignText = signText
            };

            var thePrice = sign.CalculatePrice();

            //Print out the sign and it's price
            Console.WriteLine($"{sign.RawSignText} - {thePrice.ToString("C")}");

            //Print out each word text
            //--the calculated word price
            Console.WriteLine($"Word price: {sign.NumberOfWords}");

            //--the calculated letter price
            Console.WriteLine($"Letter price: {sign.NumberOfLetters}");

            //--number of vowels and consonants
            Console.WriteLine($"Number of vowels: {sign.numOfVowels}");
            Console.WriteLine($"Number of consonants: {sign.numOfConst}");

            // is the discount applied
            Console.WriteLine($"Discount applied: {sign.isSpecialCharacter}");

            Console.ReadKey();
        }
    }
}
