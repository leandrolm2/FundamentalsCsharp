using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class41_42
{
    public class Lessons2
    {
        public static void StateSwitch()
        {
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and beautiful seasson.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It''s perfect to go to beach.");
                    break;
               default:
                    Console.WriteLine("I don't undestand that season.");
                    break;
            }
        }
    }
}
