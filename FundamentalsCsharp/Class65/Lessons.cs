using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundamentalsCsharp.Class65;
namespace FundamentalsCsharp.Class65
{
    internal class Lessons
    {
        public static void DisplaySummarisingText()
        {
            var utils = new Utils();
            var sentence = "lkasjdfh fasdjf ufurhfrn asda s  lefkekfjel d aohdsuadhf sadafasd iuoadf isdif";
            int limit = 25;
            var newText = utils.SummarisingText(sentence, limit);
            Console.WriteLine(newText, 25);
        }
    }
}
