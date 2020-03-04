using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Human : Person
    {
        //TODO add error checking to the getter and setters
        //class attributes
        public static int MAXAGE = 100;
        public string AncestralLine { get; set; }
        public Physical[] PhysicalAbilities { get; }

        //data for randomization
        public static string[] MaleFirstNames = new string[] { "Theodred", "Aragorn", "Arathorn", "Boromir", "Faramir", "Denathor", "Beren", "Eomer", "Theoden",
        "Engal", "Luk-Vohpiod", "Jilmendek", "Eavien", "Rothimzic", "Orvildien", "Stalcor"  };
        public static string[] FemaleFirstNames = new string[] { "Eowyn", "Cielle", "Lua", "Betj", "Lezeelzel", "Hihruvel", "Kafare", "Eeroh", "Jeim", "Lia", 
            "Mai", "Jei", "Mi", "Jhairrunill"};
        public static string[] LastNames = new string[] {"Rhehlon", "Morketsk", "Zoltanzefk", "Gendadrin", "Mao", "Duulueltrab", "Stiknuz", "Binzelbul", 
            "Gryedabyevu", "Horazor","Gendilbo", "Nen"  };
        //constructors
        public Human()
        {
            //instantiate object with random attributes and random number of abilities
        }
        public Human(int numberOfAbilities)
        {
            //instantiate object with random attributes, but a specified number of abilities
        }

        public void AddAbility(Physical newAbility)
        {
            //add the new ability to the PhysicalAbilities Array
        }

        public void GenerateRandomHuman(int numberOfAbilities)
        {
            //randomly assign each attribute a value
        }

        public override string ToString()
        {
            //return a more logical string eventually
            return base.ToString();
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
