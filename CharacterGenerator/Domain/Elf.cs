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
        public Mental[] ScholarlyUnderstandings { get; }
        public Physical[] PhysicalAbilities { get; }
        public Magical[] MagicalFeats { get; }

        //data for randomization
        public static string[] MaleFirstNames = new string[] {"Elrond", "Mithrandir", "Sylvan", "Legolas", "Glorfindel", "Gildor", "Elrohir", "Thranduil", "Elkhazel", 
            "Folas", "Mellon", "Almon", "Halamar", "Falael", "Tarasael","Hilerael"};
        public static string[] FemaleFirstNames = new string[] { "Galadriel", "Tauriel", "Arwen", "Luthien", "Aiwin", "Aymar", "Myrin", "Elisen", "Lethhonel", "Naesala",
            "Zentha", "Kenia", "Ialantha" };
        public static string[] LastNames = new string[] { "Oriric", "Facaryn", "Inglorien", "Valran", "Kelsalor", "Xilfir", "Daecaryn", "Greenleaf", "Gregeiros", 
            "Beiquinal", "Shomar" };
        //constructors
        public Elf()
        {
            //randomly initialize elf with random number of each ability type
        }
        
        public Elf(int numberOfAbilities)
        {
            //randomly initialize elf with desired giving each ability type the desired number of abilities
        }

        public Elf(int numberOfPhysical, int numberOfMental, int numberOfMagical)
        {
            //randomly initialize elf with each type of ability its desired amount
        }
        public void AddUnderstanding(Mental newUnderstanding)
        {
            //add the new understanding to the ScholarlyUderstandings Array
        }

        public void AddPhysicalAbility(Physical newAbility)
        {
            //add the new ability to PhysicalAbilities
        }

        public void AddMagic(Magical newSpell)
        {
            //add the new spell to the magical feats
        }

        public void GenerateRandomElf(int numberOfPhysical, int numberOfMental, int numberOfMagical)
        {
            //assign attributes randomly to elf based on the number of each ability
        }

        public override string ToString()
        {
            //will eventually return Elf in a more logical way
            return base.ToString();
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
