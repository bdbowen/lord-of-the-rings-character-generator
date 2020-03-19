using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class Ability
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private int difficultyLevel;
        public int DifficultyLevel { 
            get { return difficultyLevel; } 
            set { 
                if (value > 10 || value < 1) 
                {
                    throw new Exception("Difficulty Level must be between 1 and 10!");
                }
                difficultyLevel = value;
            } 
        }
        public bool Exhausting { get; set; }
        //random data values
        public static string[] RaceOptions = new string[] { "Elf", "Dwarf", "Hobbit", "Wizard", "Human" };

        public Ability()
        {
            Random rand = new Random();
            GenerateRandomAbility(rand);
        }

        public Ability(Random rand)
        {
            GenerateRandomAbility(rand);
        }
        public void GenerateRandomAbility(Random rand)
        {
            //Title and description are set in sub classes
            DifficultyLevel = rand.Next(1, 11);

            Exhausting = rand.Next(2) == 1;
        }

        public override string ToString()
        {
            string classString = "Title: " + Title + "\nDescription: " + Description + "\nDifficulty Level: " + DifficultyLevel.ToString()
                + "\nExhausting: " + Exhausting;
            return classString;
        }
    }
}