using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Dwarf : Person
    {
        //Class Attributes
        public static int MAXAGE = 150;
        public string DwarfType { get; set; }
        public Physical[] PhysicalAbilities { get; }

        //data for randomization
        public static string[] MaleFirstNames = new string[] { "Gimli", "Thorin", "Thrain", "Thror", "Fili", "Kili", "Bifur", "Bofur", "Bombur", "Oin", 
            "Gloin", "Balin", "Dwalin",  "Kraroud", "Darezil", "Gogheag", "Halgaem", "Yudgrour", "Whugnur"};
        public static string[] FemaleFirstNames = new string[] { "Jalmibo", "Umimrire", "Jakdrostr", "Lozuhilda", "Betgrehilda", "Debuna", "Skasoni", "Adgaren", 
            "Bomnelyn", "Nakhibena", "Nedwealin", "Fobeabo", "Throghaelda"};
        public static string[] LastNames = new string[] { "Kegmaster", "Onyxmace", "Marbleblender", "Bitterchest", "Mithriltoe", "Grimbringer", "Frostmail", 
            "Metalbow", "Kragbuster", "Blackarm", "Oakenshield", "Fieryflayer", "Emberspine" };
        //constructors
        public Dwarf()
        {
            //instantiate object with random number of abilities
        }

        public Dwarf(int numberOfAbilities)
        {
            //instantiate object with chosen number of abilities
        }

        public void AddAbility(Physical newAbility)
        {
            //add the new ability to the PhysicalAbilities Array
        }

        public void GenerateRandomDwarf(int numberOfAbilities)
        {
            //assigns random values to each attribute giving the dwarf the specific number of abilities 
        }
        public override string ToString()
        {
            //eventually return a more logical string
            return base.ToString();
        }

        public static string GenerateDwarfName(string gender)
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
