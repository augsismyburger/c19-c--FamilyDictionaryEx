using System;
using System.Collections.Generic;
using System.Linq;

namespace Family_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Augsburger Fam!");

            Dictionary<string, Dictionary<string, string>> clanAugsburger = new Dictionary<string, Dictionary<string, string>>();

            clanAugsburger.Add("pops", new Dictionary<string, string>(){ 
                {"name", "Bruce"},
                {"age", "66"}
            });
            clanAugsburger.Add("mum", new Dictionary<string, string>(){ 
                {"name", "Jan Marie"},
                {"age", "62"}
            });
            clanAugsburger.Add("sister1", new Dictionary<string, string>(){ 
                {"name", "Hailee"},
                {"age", "37"}
            });
            clanAugsburger.Add("sister2", new Dictionary<string, string>(){ 
                {"name", "Kelly"},
                {"age", "32"}
            });
            clanAugsburger.Add("brother1", new Dictionary<string, string>(){ 
                {"name", "Matt"},
                {"age", "29"}
            });
            clanAugsburger.Add("brother2", new Dictionary<string, string>(){ 
                {"name", "Andrew"},
                {"age", "29"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> kvp in clanAugsburger) {
                Console.WriteLine($"{kvp.Key}'s name is {kvp.Value["name"]} and thier age is {kvp.Value["age"]}");
            }
        }
    }
}
