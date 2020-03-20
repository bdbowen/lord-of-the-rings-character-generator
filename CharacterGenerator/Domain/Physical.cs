using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    public class Physical : Ability
    {
        public string ToolRequired { get; set; }
        public string RaceOfOrigin { get; set; }
        public Location TrainingLocation { get; set; }
        public bool Fighting { get; set; }
        public bool Lethal { get; set; }
        public bool RequiresWeaponMastery { get; set; }

        //randomDataOptions
        public static string[] TitleOptions = new string[] { "test ability"};
        public static Dictionary<string, string> DescriptionOptions = new Dictionary<string, string>
        {
            {"test ability", "This is a test" }
        };
        public static Dictionary<string, bool> isFightingPhysical = new Dictionary<string, bool>
        {
            {"test ability", false }
        };
        public static Dictionary<string, string> ToolOptions = new Dictionary<string, string>
        {
            {"test ability", "Sword" }
        };

        public Physical()
        {
            Random rand = new Random();
            GenerateRandomPhysical(rand);
        }

        public Physical(Random rand) : base(rand)
        {
            GenerateRandomPhysical(rand);
        }

        public void GenerateRandomPhysical(Random rand)
        {
            int index;
            //set title, description, tool required, and fighting
            index = rand.Next(0, TitleOptions.Length);
            Title = TitleOptions[index];
            Description = DescriptionOptions[Title];
            ToolRequired = ToolOptions[Title];
            Fighting = isFightingPhysical[Title];

            //set primary location
            TrainingLocation = new Location(rand);
            //set race
            index = rand.Next(0, RaceOptions.Length);
            RaceOfOrigin = RaceOptions[index];

            //set last booleans
            Lethal = Fighting ? rand.Next(2) == 1 : false;
            RequiresWeaponMastery = rand.Next(2) == 1;
        }
        public override string ToString()
        {
            string classString = base.ToString() + "\nTool Required: " + ToolRequired + "\nRace of Origin: " + RaceOfOrigin +
                "\nTraining Location: " + TrainingLocation.ToString() + "\nFighting: " + Fighting + "\nLethal: " + Lethal +
                "\nRequires Mastery of the " + ToolRequired + ": " + RequiresWeaponMastery;
            return classString;
        }
    }

}
