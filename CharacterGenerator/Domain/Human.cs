using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Human : Person
    {
        //TODO add error checking to the getter and setters
        //class attributes
        public static int MAXAGE = 100;
        public string AncestralLine { get; set; }
        public Physical[] PhysicalAbilities { get; }

        //constructors
        public Human()
        {
            //instantiate object with random attributes and random number of abilities
        }
        public Human(int numberOfAbilities)
        {
            //instantiate object with random attributes, but a specified number of abilities
        }

        public void AddAbility(Physical newAbility)
        {
            //add the new ability to the PhysicalAbilities Array
        }

        public void GenerateRandomHuman(int numberOfAbilities)
        {
            //randomly assign each attribute a value
        }
    }
}
