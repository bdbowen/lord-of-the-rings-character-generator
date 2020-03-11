using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class Magical : Ability
    {
        public string MagicType { get; set; }
        public Location ArchiveLocation { get; set; }
        public bool LightMagic { get; set; }

        //random data for generation
        public static string[] TitleOptions = new string[] { "test magic ability" };
        public static Dictionary<string, string> DescriptionOptions = new Dictionary<string, string>
        {
            {"test magic ability", "This is a magical test" }
        };
        public static Dictionary<string, string> MagicTypeByTitle = new Dictionary<string, string>
        {
            {"test magic ability", "Ainur" }
        };
        public Magical()
        {
            Random rand = new Random();
            GenerateRandomMagical(rand);
        }

        public Magical(Random rand) : base(rand)
        {
            GenerateRandomMagical(rand);
        }

        public void GenerateRandomMagical(Random rand)
        {
            int index;
            //set title, description, and magic type
            index = rand.Next(0, TitleOptions.Length);
            Title = TitleOptions[index];
            Description = DescriptionOptions[Title];
            MagicType = MagicTypeByTitle[Title];

            //set Archive Location
            ArchiveLocation = new Location(rand);

            //set Light Magic
            LightMagic = rand.Next(2) == 1;
        }

        public override string ToString()
        {
            string classString = base.ToString() + "\nMagic Type: " + MagicType + "\nLight Magic: " + LightMagic + 
                "\nArchive Location: " + ArchiveLocation.ToString();
            return classString;
        }
    }
}
