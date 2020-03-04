using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Wizard : Person
    {
        //class attributes
        public string MagicType { get; set; }
        public string WizardColor { get; set; }
        public Magical[] MagicalFeats { get; }
        public Physical[] PhysicalAbilities { get; }

        //data for randomization 
        public static string[] MaleFirstNames = new string[] { "Gandalf", "Saruman", "Radagast", "Ikron", "Obus", "Grumaex", "Ageor", "Ifaris", "Vraxeor", 
            "Stamanor", "Orass", "Zoshann", "Omenoran"};
        public static string[] FemaleFirstNames = new string[] {"Uthal", "Azetosh", "Shehaen", "Murune", "Ezanydae", "Virish", "Iserune", "Thagreth", 
            "Aphior", "Adrisse"};
        public static string[] WizardColors = new string[] {"White", "Blue", "Green", "Red", "Brown", "Gray", "Many-Colored", "Orange", "Gold", 
            "Silver", "Purple"};

        //constructors
        public Wizard()
        {
            // randomly generate a character with random number  of abilities
        }

        public Wizard(int numberOfAbilities)
        {
            //randomly generate a character with specific number for both abilities
        }

        public Wizard(int numberOfPhysical, int numberOfMagical)
        {
            //randomly generate a character with specific numbers for each ability type
        }

        public void AddMagic(Magical newSpell)
        {
            //add new spell to Magical Feats Array
        }
        public void AddAbility(Physical newAbility)
        {
            //add new ability to the Physical Abilities Array
        }

        public void GenerateRandomWizard(int numberOfPhysical, int numberOfMagic)
        {
            //assign random attributes
        }

        public override string ToString()
        {
            // return a more logical string 
            return base.ToString();
        }

        public static string GenerateWizardName(string gender)
        {
            string firstName, color;
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
            index = rand.Next(0, WizardColors.Length);
            color = WizardColors[index];

            return firstName + ", the " + color;
        }
    }
}
