using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Dwarf : Person
    {
        //Class Attributes
        public static int MAXAGE = 150;
        public string DwarfType { get; set; }
        public Physical[] PhysicalAbilities { get; }

        //constructors
        public Dwarf()
        {
            //instantiate object with random number of abilities
        }

        public Dwarf(int numberOfAbilities)
        {
            //instantiate object with chosen number of abilities
        }

        public void AddAbility(Physical newAbility)
        {
            //add the new ability to the PhysicalAbilities Array
        }

        public void GenerateRandomDwarf(int numberOfAbilities)
        {
            //assigns random values to each attribute giving the dwarf the specific number of abilities 
        }
        public override string ToString()
        {
            //eventually return a more logical string
            return base.ToString();
        }
    }
}
