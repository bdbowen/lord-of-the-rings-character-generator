using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Hobbit : Person
    {
        //class attributes
        public static int MAXAGE = 100;
        public string FamilyGroup { get; set; }
        public string HomeStructure { get; set; } //Whether in a hobbit hole or an actual house
        public bool IsAdventurer { get; set; }
        public bool OwnsOneRing { get; set; }
        public Physical[] PhysicalAbilities { get; }

        //constructors
        public Hobbit()
        {
            //instantiates hobbit with random number of abilities
        }

        public Hobbit(int numberOfAbilities)
        {
            //instantiates hobbit with random attributes and the chosen number of abilities
        }

        public void AddAbility(Physical newAbility)
        {
            //adds new ability to array Physical Abilities
        }

        public void GenerateRandomHobbit(int numberOfAbilities)
        {
            //assigns random values to each of the attributes listed
        }

        public override string ToString()
        {
            //eventually return a more readable string with all class attributes
            return base.ToString();
        }

    }
}
