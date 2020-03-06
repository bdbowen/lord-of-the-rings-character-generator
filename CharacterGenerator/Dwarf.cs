using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class Dwarf : Person
    {
        //Class Attributes
        public static int MAXAGE = 250;
        public string DwarfGroup { get; set; }
        public List<Physical> PhysicalAbilities { get; } = new List<Physical>();

        //data for randomization
        public static string[] MaleFirstNames = new string[] { "Gimli", "Thorin", "Thrain", "Thror", "Fili", "Kili", "Bifur", "Bofur", "Bombur", "Oin",
            "Gloin", "Balin", "Dwalin",  "Kraroud", "Darezil", "Gogheag", "Halgaem", "Yudgrour", "Whugnur"};
        public static string[] FemaleFirstNames = new string[] { "Jalmibo", "Umimrire", "Jakdrostr", "Lozuhilda", "Betgrehilda", "Debuna", "Skasoni", "Adgaren",
            "Bomnelyn", "Nakhibena", "Nedwealin", "Fobeabo", "Throghaelda"};
        public static string[] LastNames = new string[] { "Kegmaster", "Onyxmace", "Marbleblender", "Bitterchest", "Mithriltoe", "Grimbringer", "Frostmail",
            "Metalbow", "Kragbuster", "Blackarm", "Oakenshield", "Fieryflayer", "Emberspine" };
        public static string[] DwarfGroupOptions = new string[] {"Belegost Dwarf", "Erebor Dwarf", "Khazad-dum Dwarf", "Nogrod Dwarf", "Blue Mountain Dwarf",
        "Grey Mountain Dwarf", "Iron Hill Dwarf"};
        //constructors
        public Dwarf()
        {
            Random rand = new Random();
            GenerateRandomDwarf(rand.Next(5), rand);
        }

        public Dwarf(int numberOfAbilities)
        {
            GenerateRandomDwarf(numberOfAbilities, new Random());
        }

        public Dwarf(Random rand)
        {
            GenerateRandomDwarf(rand.Next(5), rand);
        }

        public void GenerateRandomDwarf(int numberOfAbilities, Random rand)
        {
            int index;
            //set name
            Name = GenerateDwarfName(Gender, rand);

            //reset age
            Age = rand.Next(1, MAXAGE);

            //set DwarfFamily
            index = rand.Next(0, DwarfGroupOptions.Length);
            DwarfGroup = DwarfGroupOptions[index];
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

            string classString = "Dwarf Type: " + DwarfGroup + "\n" + base.ToString() + "\nPhysical Abilities: " + physicalString;
            return classString;
        }

        public static string GenerateDwarfName(string gender, Random rand)
        {
            string firstName, lastName;
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
