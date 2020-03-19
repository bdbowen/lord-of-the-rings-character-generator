using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class Mental : Ability
    {
        public string RaceOfOrigin { get; set; }
        public string Subject { get; set; }
        public Location SchoolLocation { get; set; }
        public bool RequiresSubjectMastery { get; set; }

        //random data for generation
        public static string[] SubjectOptions = new string[] { "Lore of the Peoples of Middle Earth", "Ancient History", "Modern Craftmanship" };
        public static Dictionary<string, string[]> TitleOptions = new Dictionary<string, string[]>
        {
            {"Lore of the Peoples of Middle Earth", new string[] {"Knowledge of Dwarves", "Knowledge of Men", "Knowledge of Elves", "Knowledge of Druedain", "Knowledge of Hobbits" } },
            {"Ancient History", new string[] {"Knowledge of the Ages of Middle Earth", "Knowledge of the Rings of Power", "Knowledge of Ancient Weaponry", "Knowledge of the Valar"} },
            {"Modern Craftmanship", new string[] {"Knowledge of Modern Weaponry", "Knowledge of Dwarven Craftmanship" } }
        };
        public static Dictionary<string, string> DescriptionOptions = new Dictionary<string, string>
        {
            {"Knowledge of Hobbits", "An understanding of the inner workings of the Hobbits. Not many among the wise study on this people." },
            {"Knowledge of Druedain", "An understanding of the wild men outside of Gondor. Not many know of these men. Distinct from the Knowledge of Men, because the Druedain are reclusive from the rest of the world." },
            {"Knowledge of Elves", "An understanding of the elves, and the different races of elves, and how they came to be." },
            {"Knowledge of Dwarves", "An understanding of the practices of the dwarves, and their history." },
            {"Knowledge of Men", "An understanding of the practices of the men, and their history, and the different ancestral lines of men." },
            {"Knowledge of the Ages of Middle Earth", "An understanding of the First Age with Morgoth, and the Second Age with Sauron, and now the Third Age. A comprehensive understanding of the history of Middle Earth." },
            {"Knowledge of the Rings of Power", "An understanding of the history of the history of the Rings of Power: nine rings for men, seven rings for Dwarves, three rings for elves, and the One Ring to rule them all" },
            {"Knowledge of Ancient Weaponry", "An understanding of the different types of weapons, and recognition of any ancient weapon" },
            {"Knowledge of Modern Weaponry", "An understanding of the different types of weapons, and recognition of any modern weapon" },
            {"Knowledge of the Valar", "An understanding of where Middle Earth came from, and studied the Valar and Maiar, who brought Middle Earth into existence" },
            {"Knowledge of Dwarven Craftmanship", "An understanding of how the dwarves make elaborate artifacts. The dwarves are metalsmiths and minors, whose craftmanship knows no equal." }
        };
        
        public Mental()
        {
            Random rand = new Random();
            GenerateRandomMental(rand);
        }

        public Mental(Random rand) : base(rand)
        {
            GenerateRandomMental(rand);
        }

        public void GenerateRandomMental(Random rand)
        {
            int index;
            //set title, description, and magic type
            index = rand.Next(0, SubjectOptions.Length);
            Subject = SubjectOptions[index];
            string[] titleOptions = TitleOptions[Subject];
            index = rand.Next(0, titleOptions.Length);
            Title = titleOptions[index];
            Description = DescriptionOptions[Title];

            //set School Location
            SchoolLocation = new Location(rand);

            //set requires subject mastery
            RequiresSubjectMastery = rand.Next(2) == 1;
        }
        public override string ToString()
        {
            string classString = base.ToString() + "\nRace of Origin: " + RaceOfOrigin + "\nSubject: " + Subject +
                "\nSchool Location: " + SchoolLocation.ToString() + "\nRequires Mastery of the " + Subject + ": " + 
                RequiresSubjectMastery;
            return classString;
        }
    }

}
