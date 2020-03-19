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
        public static string[] MagicTypesOptions = new string[] { "Ainur Magic", "Dwarven Magic", "Elven Magic", "Dark Magic" };
        public static Dictionary<string, string> DescriptionOptions = new Dictionary<string, string>
        {
            {"You Shall not Pass", "An ability that keeps an enemy from being able to pass you. Requires great strength, and can only be used in dire need." },
            { "Flaming Pinecones",  "Lighting Pinecones on Fire can help anyone get out of a very difficult situation" },
            { "Shield of Light", "Summon a shield to protect the wielder against all physical attacks of the enemy" },
            { "Fireworks", "A nice ability for becoming popular among the hobbits, and not much fighting use, but it may come in handy" },
            { "Necromancy", "The power to summon the dead" },
            { "Forging of Morgul Blades",  "Terrible blades that corrupt the very soul of a person. It begins to kill them by making the person a shade in the shadow realm of the Nazgul"},
            { "Moon Runes", "Writing with ink that only can be seen by the light of a particular type of moon" },
            { "Hidden Doors", "Once Locked these doors cannot be seen without help" },
            { "Crafting of the Rings of Power", "The ability to imbue into a ring great power" },
            { "Crafting of the Enchanted Swords", "Crafting mighty swords, such as Glamdring or Orcrist as they were forged in Gondolin. Or the reforging  of Anduril by Elrond. This is a special craft to forge a sword possessing special magical abilities" },
            { "Healing", "This is enhanced through the use of the athelos or Kings Foil. The best healers in Middle Earth possess this power." }
        };
        public static Dictionary<string, string[]> TitleByMagicType = new Dictionary<string, string[]>
        {
            { "Ainur Magic", new string [] {"You Shall not Pass", "Flaming Pinecones", "Shield of Light", "Fireworks" } },
            { "Dark Magic", new string[] {"Necromancy", "Forging of Morgul Blades" } },
            { "Dwarven Magic", new string[] { "Moon Runes", "Hidden Doors" } },
            { "Elven Magic", new string[] { "Crafting of the Rings of Power", "Crafting of the Enchanted Swords", "Healing" } }
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
            index = rand.Next(0, MagicTypesOptions.Length);
            MagicType = MagicTypesOptions[index];
            string[] titleOptions = TitleByMagicType[MagicType];
            index = rand.Next(0, titleOptions.Length);
            Title = titleOptions[index];
            Description = DescriptionOptions[Title];

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
