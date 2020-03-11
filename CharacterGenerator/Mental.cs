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
        public static string[] TitleOptions = new string[] { "test mental ability" };
        public static Dictionary<string, string> DescriptionOptions = new Dictionary<string, string>
        {
            {"test mental ability", "This is a mental test" }
        };
        public static Dictionary<string, string> SubjectOptions = new Dictionary<string, string>
        {
            {"test mental ability", "Science" }
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
            index = rand.Next(0, TitleOptions.Length);
            Title = TitleOptions[index];
            Description = DescriptionOptions[Title];
            Subject = SubjectOptions[Title];

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
