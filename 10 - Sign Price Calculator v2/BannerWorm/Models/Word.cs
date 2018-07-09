using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BannerWorm.Models
{
    public class Word
    {
        // Prices defined
        public double WordPrice { get; private set; }
        public double LetterPrice { get; private set; }
        public double Price { get; set; }
        
        // Input defined
        public string RawWordText { get; set; }

        public double CalculatePrice(double pricePerWord, double pricePerLetter)
        {
            WordPrice = pricePerWord;
            LetterPrice = LetterPrice + pricePerLetter * RawWordText.ToCharArray().Length;

            return WordPrice + LetterPrice;
        }
    }
}
