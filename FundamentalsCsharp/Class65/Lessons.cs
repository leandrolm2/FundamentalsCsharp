using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class65
{
    internal class Lessons
    {
        private static string SummarisingText(string text, int maxLength = 20)
        {
            

            if(text.Length < maxLength)
            {
                return text;
            } else
            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();
                foreach(var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if(totalCharacters > maxLength)
                    {
                        break;
                    }
                }

                return String.Join(" ", summaryWords) + "...";
            }
        }

        public static void DisplaySummarisingText()
        {
            var sentence = "lkasjdfh fasdjf ufurhfrn asda s  lefkekfjel d aohdsuadhf sadafasd iuoadf isdif";
            var newText = SummarisingText(sentence);
            Console.WriteLine(newText, 25);
        }
    }
}
