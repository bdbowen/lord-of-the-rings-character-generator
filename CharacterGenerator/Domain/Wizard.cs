﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class Wizard : Person
    {
        //class attributes
        public string MagicType { get; set; }
        public string WizardColor { get; set; }
        public List<Magical> MagicalFeats { get; } = new List<Magical>();
        public List<Physical> PhysicalAbilities { get; } = new List<Physical>();
        public List<Mental> FieldsOfWisdom { get; } = new List<Mental>();

        //data for randomization 
        public static string[] MaleFirstNames = new string[] { "Gandalf", "Saruman", "Radagast", "Ikron", "Obus", "Grumaex", "Ageor", "Ifaris", "Vraxeor",
            "Stamanor", "Orass", "Zoshann", "Omenoran"};
        public static string[] FemaleFirstNames = new string[] {"Uthal", "Azetosh", "Shehaen", "Murune", "Ezanydae", "Virish", "Iserune", "Thagreth",
            "Aphior", "Adrisse"};
        public static string[] WizardColors = new string[] {"White", "Blue", "Green", "Red", "Brown", "Gray", "Many-Colored", "Orange", "Gold",
            "Silver", "Purple"};
        public static string[] MagicTypeOptions = new string[] { "Ainur Magic", "Elven Magic", "Dwarven Magic", "Dark Magic" };
        //constructors
        public Wizard()
        {
            Random rand = new Random();
            int physical = rand.Next(1, 5);
            int magical = rand.Next(1, 5);
            int mental = rand.Next(1, 5);

            GenerateRandomWizard(physical, magical, mental, rand);
        }

        public Wizard(Random rand) : base(rand)
        {
            int physical = rand.Next(1, 5);
            int magical = rand.Next(1, 5);
            int mental = rand.Next(1, 5);

            GenerateRandomWizard(physical, magical, mental, rand);
        }

        public Wizard(int numberOfAbilities)
        {
            GenerateRandomWizard(numberOfAbilities, numberOfAbilities, numberOfAbilities, new Random());
        }

        public Wizard(int numberOfPhysical, int numberOfMagical, int numberOfMental)
        {
            GenerateRandomWizard(numberOfPhysical, numberOfMagical, numberOfMental, new Random());
        }


        public void GenerateRandomWizard(int numberOfPhysical, int numberOfMagic, int numberOfMental, Random rand)
        {
            RaceType = "Wizard";
            int index;
            //set wizard color
            index = rand.Next(0, WizardColors.Length);
            WizardColor = WizardColors[index];

            //set Name
            Name = GenerateWizardName(Gender, rand, WizardColor);

            //Generate Magic Type
            index = rand.Next(0, MagicTypeOptions.Length);
            MagicType = MagicTypeOptions[index];

            //set abilities
            for (int i = 0; i < numberOfPhysical; i++)
            {
                PhysicalAbilities.Add(new Physical(rand));
            }

            for (int i = 0; i < numberOfMagic; i++)
            {
                MagicalFeats.Add(new Magical(rand));
            }
            for (int i = 0; i < numberOfMental; i++)
            {
                FieldsOfWisdom.Add(new Mental(rand));
            }
        }

        public override string ToString()
        {
            string physicalString = "";
            foreach (Physical phys in PhysicalAbilities)
            {
                physicalString += phys.ToString();
            }

            string magicalString = "";
            foreach (Magical spell in MagicalFeats)
            {
                magicalString += spell.ToString();
            }
            string mentalString = "";
            foreach (Mental lore in FieldsOfWisdom)
            {
                mentalString += lore.ToString();
            }
            string classString = "Magic Type: " + MagicType + "\nWizard Color: " + WizardColor + "\n" + base.ToString() + "\nPhysical Abilities: " +
                physicalString + "\nMagical Feats: " + magicalString + "\nFields of Wisdom" + FieldsOfWisdom;
            return classString;
        }

        public static string GenerateWizardName(string gender, Random rand, string color = null)
        {
            string firstName;
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
            if (color == null)
            {
                index = rand.Next(0, WizardColors.Length);
                color = WizardColors[index];
            }

            return firstName + ", the " + color;
        }
    }

}