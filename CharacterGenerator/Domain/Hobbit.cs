using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class Hobbit : Person
    {
        //class attributes
        public static int MAXAGE = 130;
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
        public static string[] HomeTypeOptions = new string[] { "Hobbit Hole", "Above Ground House" };
        //constructors
        public Hobbit()
        {
            Random rand = new Random();
            GenerateRandomHobbit(rand.Next(1, 5), rand);
        }

        public Hobbit(Random rand) : base(rand)
        {
            GenerateRandomHobbit(rand.Next(1, 5), rand);
        }

        public Hobbit(int numberOfAbilities)
        {
            GenerateRandomHobbit(numberOfAbilities, new Random());
        }

        public void GenerateRandomHobbit(int numberOfAbilities, Random rand)
        {
            RaceType = "Hobbit";
            int index;

            //set Name
            Name = GenerateHobbitName(Gender, rand);

            //reset age
            Age = rand.Next(1, MAXAGE);

            //set Home type
            index = rand.Next(0, HomeTypeOptions.Length);
            HomeType = HomeTypeOptions[index];

            //set Booleans
            OwnsOneRing = rand.Next(2) == 1;
            IsAdventurer = rand.Next(2) == 1;

            //set abilities
            for (int i = 0; i < numberOfAbilities; i++)
            {
                PhysicalAbilities.Add(new Physical(rand));
            }
        }

        public override string ToString()
        {
            string physicalString = "";
            foreach (Physical phys in PhysicalAbilities)
            {
                physicalString += phys.ToString();
            }

            string classString = base.ToString() + "\nHome Type: " + HomeType + "\nPhysical Abilities: " +
                physicalString + "\nIs Adventurer: " + IsAdventurer + "\nOwns the One Ring: " + OwnsOneRing;
            return classString;
        }
        public static string GenerateHobbitName(string gender, Random rand)
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
