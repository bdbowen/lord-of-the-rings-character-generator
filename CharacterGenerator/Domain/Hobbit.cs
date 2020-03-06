using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Hobbit : Person
    {
        //class attributes
        public static int MAXAGE = 100;
        public string HomeType { get; set; } //Whether in a hobbit hole or an actual house
        public bool IsAdventurer { get; set; }
        public bool OwnsOneRing { get; set; }
        public List<Physical> PhysicalAbilities { get; } = new List<Physical>();

        //data for randomization
        public static string[] MaleFirstNames = new string[] { "Frodo", "Bilbo", "Samwise", "Perigrin", "Lotho", "Radigis", "Ramnulf", "Humbert", 
            "Balbo", "Ceufroy", "Taurin", "Clovis", "Theodoric", "Sigismond", "Wolbodo"};
        public static string[] FemaleFirstNames = new string[] { "Lobellia", "Mariah", "Arabella", "Angela", "Faileuba", "Eadgithu", "Sydney", 
            "Adele", "Pervinca", "Basina", "Rotrude", "Cassandra"};
        public static string[] LastNames = new string[] {"Took", "Baggins", "Brandybuck", "Proudfoot", "Sackville", "Sackville-Baggins", "Gamgee",
        "Boffin", "Bolger", "Bracegirdle", "Burrowes", "Chubb", "Grubb", "Hornblower", "Sandyman", "Underhill"};
        //constructors
        public Hobbit()
        {
            //instantiates hobbit with random number of abilities
        }

        public Hobbit(int numberOfAbilities)
        {
            //instantiates hobbit with random attributes and the chosen number of abilities
        }

        public void AddAbility(Physical newAbility)
        {
            //adds new ability to array Physical Abilities
        }

        public void GenerateRandomHobbit(int numberOfAbilities)
        {
            //assigns random values to each of the attributes listed
        }

        public override string ToString()
        {
            //eventually return a more readable string with all class attributes
            return base.ToString();
        }
        public static string GenerateHobbitName(string gender)
        {
            string firstName, lastName;
            Random rand = new Random();
            int index;
            if (gender.ToLower() == "female")
            {
                index = rand.Next(0, FemaleFirstNames.Length);
                firstName = FemaleFirstNames[index];
            } else
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
