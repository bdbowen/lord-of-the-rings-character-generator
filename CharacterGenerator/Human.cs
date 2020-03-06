using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class Human : Person
    {
        //class attributes
        public static int MAXAGE = 100;
        public string AncestralLine { get; set; }
        public List<Physical> PhysicalAbilities { get; } = new List<Physical>();

        //data for randomization
        public static string[] MaleFirstNames = new string[] { "Theodred", "Aragorn", "Arathorn", "Boromir", "Faramir", "Denathor", "Beren", "Eomer", "Theoden",
        "Engal", "Luk-Vohpiod", "Jilmendek", "Eavien", "Rothimzic", "Orvildien", "Stalcor"  };
        public static string[] FemaleFirstNames = new string[] { "Eowyn", "Cielle", "Lua", "Betj", "Lezeelzel", "Hihruvel", "Kafare", "Eeroh", "Jeim", "Lia",
            "Mai", "Jei", "Mi", "Jhairrunill"};
        public static string[] LastNames = new string[] {"Rhehlon", "Morketsk", "Zoltanzefk", "Gendadrin", "Mao", "Duulueltrab", "Stiknuz", "Binzelbul",
            "Gryedabyevu", "Horazor","Gendilbo", "Nen"  };
        public static string[] AncestralLineOptions = new string[] {"Edain", "Dunadain", "Black Numenorians", "Haradrim", "Easterlings", "Northmen", "Dunlendings",
            "Druedain"};
        //constructors
        public Human()
        {
            Random rand = new Random();

            GenerateRandomHuman(rand.Next(5));
        }
        public Human(int numberOfAbilities)
        {
            GenerateRandomHuman(numberOfAbilities);
        }

        public void GenerateRandomHuman(int numberOfAbilities)
        {
            Random rand = new Random();
            int index;
            //set name
            Name = GenerateHumanName(Gender);

            //reset age
            Age = rand.Next(1, MAXAGE);

            //set ancestral line
            index = rand.Next(0, AncestralLineOptions.Length);
            AncestralLine = AncestralLineOptions[index];

            //set abilities
            for (int i = 0; i < numberOfAbilities; i++)
            {
                PhysicalAbilities.Add(new Physical());
            }
        }

        public override string ToString()
        {
            string physicalString = "";
            foreach (Physical phys in PhysicalAbilities)
            {
                physicalString += phys.ToString();
            }

            string classString = "Ancestral Line: " + AncestralLine + "\n" + base.ToString() + "\nPhysical Abilities: " +
                physicalString;
            return classString;
        }

        public static string GenerateHumanName(string gender)
        {
            string firstName, lastName;
            Random rand = new Random();
            int index;
            if (gender.ToLower() == "female")
            {
                index = rand.Next(0, FemaleFirstNames.Length);
                firstName = FemaleFirstNames[index];
            }
            else
            {
                index = rand.Next(0, MaleFirstNames.Length);
                firstName = MaleFirstNames[index];
            }
            index = rand.Next(0, LastNames.Length);
            lastName = LastNames[index];

            return firstName + " " + lastName;
        }
    }
}
