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
    }
}
