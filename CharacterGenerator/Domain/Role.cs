using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CharacterGenerator
{
    class Role
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private string primaryRace;
        public string PrimaryRace { 
            get { return primaryRace; } 
            set {
                if (Array.IndexOf(RaceOptions, value) > -1)
                {
                    primaryRace = value;
                } else
                {
                    throw new Exception("Please choose one of the races: elf, hobbit, dwarf, human or wizard for the primary race");
                }
            } 
        }
        public int NumberOfSubordinates { get; set; }
        public int LenthOfOccupancy { get; set; }
        public bool SupremeRole { get; set; }

        //generic data to initialize with
        public static string[] MaleTitleOptions = new string[] { "King", "Lord", "Prince", "General",  "Warrior", "Knight", "Dragon Slayer", "Burglar"};
        public static string[] FemaleTitleOptions = new string[] { "Queen", "Princess", "Lady", "Damsel in Distress", "Warrior", "Dragon Slayer", "Burglar"};
        public static string[] RaceOptions = new string[] { "Elf", "Dwarf", "Hobbit", "Wizard", "Human" };
        public static Dictionary<string, string> DescriptionOptions = new Dictionary<string, string>()
        {
            {"King", "Sovereign ruler of his country" },
            {"Queen", "Rules alongside of her husband, the king" },
            {"Lord", "A male noble, who has limited functioning within the country. Sometimes he is leader of a city" },
            {"Lady", "A female noble, who has limited funcitioning within the country. Sometimes she is a leader of a city" },
            {"Prince", "Son of a king, and is often the heir apparent to take the throne upon the king's death" },
            {"Princess", "Daughter of a king and queen, and is in the royal house" },
            {"Damsel in Distress", "Woman who is in trouble." },
            {"Warrior", "A valiant fighter, who gives their life for king and country" },
            {"Knight", "A male fighter, who is employed by lords" },
            {"Dragon Slayer", "One who has slain a dragon" },
            {"Buglar", "A thief, who is good at sneaking around" }

        };
        public static string[] SupremeRoles = new string[] { "King", "Queen", "Dragon Slayer" };
        public Role()
        {
            GenerateRandomRole();
        }

        public Role(string gender, int maxAge = -1)
        {
            GenerateRandomRole(gender.ToLower(), maxAge);
        }

        public void GenerateRandomRole(string gender = null, int maxAge = -1)
        {
            Random rand = new Random();
            int index;
            //randomize Title
            if (gender == "male")
            {
                index = rand.Next(0, MaleTitleOptions.Length);
                Title = MaleTitleOptions[index];
            } else if (gender == "female")
            {
                index = rand.Next(0, FemaleTitleOptions.Length);
                Title = FemaleTitleOptions[index];
            } else
            {
                string[] intersection = MaleTitleOptions.Intersect(FemaleTitleOptions).ToArray();
                index = rand.Next(0, intersection.Length);
                Title = intersection[index];
            }
            //set description
            Description = DescriptionOptions[Title];

            //set Primary Race
            index = rand.Next(0, RaceOptions.Length);
            PrimaryRace = RaceOptions[index];

            //set length of occupancy 
            maxAge = maxAge <= 0 ? 10000 : maxAge;
            LenthOfOccupancy = rand.Next(1, maxAge);

            //set number of subordinates
            NumberOfSubordinates = rand.Next();

            //set whether it is a Supreme Role
            SupremeRole = SupremeRoles.Contains(Title);
        }

        public override string ToString()
        {
            string classString = "Title: " + Title + "\n Description: " + Description + "\n Primary Race for this Role: " + PrimaryRace + 
                "\n Amount of Time this Person occupied this Role: " + LenthOfOccupancy + " years \n Number of Subordinants: " + NumberOfSubordinates +"\n Supreme Role: " + SupremeRole;
            return classString;
        }
    }
}
