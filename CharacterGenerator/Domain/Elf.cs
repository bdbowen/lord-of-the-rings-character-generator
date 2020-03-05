using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Elf : Person
    {
        //TODO: add error checking for all the getter and setter methods
        //Elf Attributes
        //Personal Information
        public string ElfType { get; set; }
        public bool OwnsRingOfPower { get; set; }

        //Abilities
        public List<Mental> ScholarlyUnderstandings { get; } = new List<Mental>();
        public List<Physical> PhysicalAbilities { get; } = new List<Physical>();
        public List<Magical> MagicalFeats { get; } = new List<Magical>();

        //data for randomization
        public static string[] MaleFirstNames = new string[] {"Elrond", "Mithrandir", "Sylvan", "Legolas", "Glorfindel", "Gildor", "Elrohir", "Thranduil", "Elkhazel", 
            "Folas", "Mellon", "Almon", "Halamar", "Falael", "Tarasael","Hilerael"};
        public static string[] FemaleFirstNames = new string[] { "Galadriel", "Tauriel", "Arwen", "Luthien", "Aiwin", "Aymar", "Myrin", "Elisen", "Lethhonel", "Naesala",
            "Zentha", "Kenia", "Ialantha" };
        public static string[] LastNames = new string[] { "Oriric", "Facaryn", "Inglorien", "Valran", "Kelsalor", "Xilfir", "Daecaryn", "Greenleaf", "Gregeiros", 
            "Beiquinal", "Shomar" };
        public static string[] ElfTypeOptions = new string[] { "Vanyar", "Noldor", "Teleri", "Avari", "Sindar", "Nandor - Silvan", "Nandor - Laiquendi", "Avari"  };

        //constructors
        public Elf()
        {
            Random rand = new Random();
            int physical = rand.Next(1, 3);
            int mental = rand.Next(1, 3);
            int magical = rand.Next(1, 3);

            GenerateRandomElf(physical, mental, magical);
        }
        
        public Elf(int numberOfAbilities)
        {
            GenerateRandomElf(numberOfAbilities, numberOfAbilities, numberOfAbilities);
        }

        public Elf(int numberOfPhysical, int numberOfMental, int numberOfMagical)
        {
            GenerateRandomElf(numberOfPhysical, numberOfMental, numberOfMagical);
        }

        public void GenerateRandomElf(int numberOfPhysical, int numberOfMental, int numberOfMagical)
        {
            Random rand = new Random();
            int index;
            //set Elf
            Name = GenerateElfName(Gender);
            
            //set Elf Type
            index = rand.Next(0, ElfTypeOptions.Length);
            ElfType = ElfTypeOptions[index];
            
            //set owns ring of power
            OwnsRingOfPower = rand.Next(2) == 1;

            //set abilities
            for(int i=0; i<numberOfPhysical; i++)
            {
                PhysicalAbilities.Add(new Physical());
            }

            for (int i = 0; i < numberOfMental; i++)
            {
                ScholarlyUnderstandings.Add(new Mental());
            }

            for (int i = 0; i < numberOfMagical; i++)
            {
                MagicalFeats.Add(new Magical());
            }

            //assign attributes randomly to elf based on the number of each ability
        }

        public override string ToString()
        {
            string physicalString = "";
            foreach(Physical phys in PhysicalAbilities)
            {
                physicalString += phys.ToString();
            }

            string mentalString = "";
            foreach (Mental ment in ScholarlyUnderstandings)
            {
                mentalString += ment.ToString();
            }

            string magicalString = "";
            foreach (Magical spell in MagicalFeats)
            {
                magicalString += spell.ToString();
            }
            string classString = "Elf Type: " + ElfType + "\nOwns Elven Ring: " + OwnsRingOfPower + "\n" + base.ToString() + "\nPhysical Abilities: " + 
                physicalString + "\nScholarly Understandings: " + mentalString + "\nMagical Feats: " + magicalString;
            return classString;
        }

        public static string GenerateElfName(string gender)
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
