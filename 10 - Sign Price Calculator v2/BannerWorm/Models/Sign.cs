using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BannerWorm.Models
{
    public class Sign
    {
        // Prices defined
        //private double _firstWordPrice = 1.113;
        private double _firstWordPrice = Convert.ToDouble(ConfigurationSettings.AppSettings["FirstWordPrice"]);
        private double _otherWordPrice = 2.256789;
        private double _letterPrice = .3333;
        private double _VowelLetterPrice = .529;
        private double _ConstLetterPrice = .6666667;
        private double _nonAlphaWordDiscount = .015;

        // Input defined
        public string RawSignText { get; set; }
        public int NumberOfWords { get; private set; }
        public int NumberOfLetters { get; private set; }
        public int numOfVowels;
        public int numOfConst;
        public bool isSpecialCharacter = false;
        public List<Word> Words { get; set; }

        public double CalculatePrice()
        {
            // Create words list and define vowels
            Words = new List<Word>();

            // Separate words into list and loop through
            var words = RawSignText.Split(' ').ToList();
            foreach (var word in words)
            {
                var w = new Word
                {
                    RawWordText = word
                };
                Words.Add(w);
                w.CalculatePrice(_otherWordPrice, _letterPrice);
                NumberOfWords++;
            }

            // Identify special characters and vowels from consonants
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] specialCharacters = new char[] { '!', '@', '#', '$', '%', '^', '&', '*',
                '(', ')', '-', '_', '=', '+'};
            var letters = RawSignText.ToLower().ToCharArray();

            // Loop through and increment vowel and consonant count
            foreach (var letter in letters)
            {
                if (letter == vowels[0] || letter == vowels[1] ||
                    letter == vowels[2] || letter == vowels[3] || letter == vowels[4])
                {
                    numOfVowels++;
                }
                else
                {
                    numOfConst++;
                }
                NumberOfLetters++;
            }

            // Loop through for special characters
            foreach (var letter in letters)
            {
                if (letter == specialCharacters[0] || letter == specialCharacters[1] ||
                    letter == specialCharacters[2] || letter == specialCharacters[3] ||
                    letter == specialCharacters[4] || letter == specialCharacters[5] ||
                    letter == specialCharacters[6] || letter == specialCharacters[7] ||
                    letter == specialCharacters[8] || letter == specialCharacters[9] ||
                    letter == specialCharacters[10] || letter == specialCharacters[11] ||
                    letter == specialCharacters[12] || letter == specialCharacters[13])
                {
                    isSpecialCharacter = true;
                    NumberOfLetters = NumberOfLetters - 1;
                    numOfConst = numOfConst - 1;
                }
                else
                {
                    isSpecialCharacter = false;
                }
            }

            // Calculate the prices
            var runningTotal = _firstWordPrice;
            runningTotal = runningTotal + (words.Count - 1) * _otherWordPrice;

            // Get totals
            runningTotal = runningTotal + (numOfVowels * _VowelLetterPrice);
            runningTotal = runningTotal + ((numOfConst - 1)  * _ConstLetterPrice);

            // Apply discount if special character is present
            if (isSpecialCharacter == true)
            {
                var discount = runningTotal * _nonAlphaWordDiscount;
                runningTotal = runningTotal - discount;
            }

            return runningTotal;
        }
    }
}
