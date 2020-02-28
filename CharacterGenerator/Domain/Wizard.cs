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
    }
}
