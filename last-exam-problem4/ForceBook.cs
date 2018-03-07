using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class ForceBook
    {
        static void Main()
        {
            Dictionary<string, List<string>> sidesWithUsers = new Dictionary<string, List<string>>();
            Dictionary<string, string> usersWithSide = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {
                string user = string.Empty;
                string side = string.Empty;
                if (input.Contains(" | "))
                {
                    string[] token = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                    user = token[1];
                    side = token[0];
                    if (usersWithSide.ContainsKey(user))
                    {
                        //usersWithSide[user] = side;
                    }
                    else
                    {
                        usersWithSide.Add(user, side);
                    }
                }
                if (input.Contains(" -> "))
                {
                    string[] token = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    user = token[0];
                    side = token[1];
                    if (usersWithSide.ContainsKey(user))
                    {
                        usersWithSide[user] = side;
                    }
                    else
                    {
                        usersWithSide.Add(user, side);
                    }
                    Console.WriteLine("{0} joins the {1} side!", user, side);
                }
                input = Console.ReadLine();
            }
            foreach (var Side in usersWithSide)
            {
                string side = Side.Value;
                string user = Side.Key;
                if (sidesWithUsers.ContainsKey(side))
                {
                    sidesWithUsers[side].Add(user);
                }
                else
                {
                    sidesWithUsers.Add(side, new List<string>() { user });
                }
            }
            foreach (var side in sidesWithUsers.OrderByDescending(c => c.Value.Count).ThenBy(n => n.Key))
            {
                //if (side.Value.Count > 0)
                //{
                    Console.WriteLine("Side: {0}, Members: {1}", side.Key, side.Value.Count);
                    foreach (string user in side.Value.OrderBy(m => m))
                    {
                        Console.WriteLine("! {0}", user);
                    }
                //}
            }
        }
    }
}
