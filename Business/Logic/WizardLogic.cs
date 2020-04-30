using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;

namespace CharacterGenerator
{
    public class WizardLogic : IGenerate<Wizard>
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud

        public Wizard GetWizard(int wizardID)
        {
            var wizard = context.Wizards.Find(wizardID);
            return wizard;
        }
        public IEnumerable<Wizard> GetAllWizards()
        {
            var wizards = context.Wizards.ToList();
            return wizards;
        }
        public void AddWizard(Wizard myWizard)
        {
            context.Wizards.Add(myWizard);
            context.SaveChanges();
        }

        public void UpdateWizard()
        {
            context.SaveChanges();
        }

        public void DeleteWizard(Wizard myWizard)
        {
            context.Wizards.Remove(myWizard);
            context.SaveChanges();
        }
       
        /*public List<Magical> MagicalFeats { get; } = new List<Magical>();
        public List<Physical> PhysicalAbilities { get; } = new List<Physical>();
        public List<Mental> FieldsOfWisdom { get; } = new List<Mental>();*/

        //data for randomization 
        public static string[] MaleFirstNames = new string[] { "Gandalf", "Saruman", "Radagast", "Ikron", "Obus", "Grumaex", "Ageor", "Ifaris", "Vraxeor",
            "Stamanor", "Orass", "Zoshann", "Omenoran"};
        public static string[] FemaleFirstNames = new string[] {"Uthal", "Azetosh", "Shehaen", "Murune", "Ezanydae", "Virish", "Iserune", "Thagreth",
            "Aphior", "Adrisse"};
        public static string[] WizardColors = new string[] {"White", "Blue", "Green", "Red", "Brown", "Gray", "Many-Colored", "Orange", "Gold",
            "Silver", "Purple"};
        public static string[] MagicTypeOptions = new string[] { "Ainur Magic", "Elven Magic", "Dwarven Magic", "Dark Magic" };

        public Wizard Generate(Random rand, int numberOfPhysical, int numberOfMagic, int numberOfMental)
        {
            PersonLogic personLogic = new PersonLogic();

            Wizard wizard = (Wizard) personLogic.Generate("wizard", rand, new Wizard());

            wizard.RaceType = "wizard";
            int index;
            //set wizard color
            index = rand.Next(0, WizardColors.Length);
            wizard.WizardColor = WizardColors[index];

            //set Name
            wizard.Name = GenerateName(wizard.Gender, rand, wizard.WizardColor);


            //Generate Magic Type
            index = rand.Next(0, MagicTypeOptions.Length);
            wizard.MagicType = MagicTypeOptions[index];

            //set abilities -> future
            /*for (int i = 0; i < numberOfPhysical; i++)
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
            }*/
            AddWizard(wizard);


            personLogic.GenerateAdventures(wizard.PersonID, rand.Next(1,10), rand);
            return wizard;
        }
        public string GenerateName(string gender, Random rand)
        {
            int index = rand.Next(0, WizardColors.Length);
            string color = WizardColors[index];

            return GenerateName(gender, rand, color);
        }
        public string GenerateName(string gender, Random rand, string color)
        {
            string firstName;
            int index;
            if (gender.ToLower() == "f")
            {
                index = rand.Next(0, FemaleFirstNames.Length);
                firstName = FemaleFirstNames[index];
            }
            else
            {
                index = rand.Next(0, MaleFirstNames.Length);
                firstName = MaleFirstNames[index];
            }

            return firstName + ", the " + color;
        }
    }

}
