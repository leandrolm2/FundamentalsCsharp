using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FundamentalsCsharp.Challengs.ArraysAndLists
{
    public class Ch1
    {
        public static void displayName(List<string> names) 
        {
            string friendNames = "";
            switch(names.Count)
            {
                case 0:
                    Console.WriteLine("You have no friends or passed none valid values");
                    break;
                case 1:
                case 2:
                    for(int i = 0; i < names.Count; i++)
                    {
                        Console.WriteLine($"{names[0]}, ");
                    }
                    Console.WriteLine("liked your post");
                    break;
                default:
                    for (int i = 0; i < 2; i++)
                    {
                        friendNames += names[i] + ", ";
                        names.Remove(names[i]);
                    }
                    friendNames += $"and {names.Count} others like your post.";
                    Console.WriteLine(friendNames);
                    break;

            }
        }
        public static void displayFriendsName()
        {
            bool askAboutFriends = true;

            var names = new List<string>();

            while (askAboutFriends)
            {
                Console.WriteLine("Type friends name:");
                string isNameValid = Console.ReadLine();

                if (!String.IsNullOrEmpty(isNameValid))
                {
                    names.Add(isNameValid);
                }

                Console.WriteLine("Do you have any more friends?:");
                Console.WriteLine("Type only yes or no?:");
                string isFinidhed = Console.ReadLine();

                if(isFinidhed == "no")
                {
                    askAboutFriends = false;
                }
            }

            displayName(names);
        }
    }
}
