using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Magical : Ability
    {
        public string ElementType { get; set; }
        public Location ArchiveLocation { get; set; }
        public bool LightMagic { get; set; }

        public Magical()
        {
            //generates random Magical Ability Object
        }

        public void GenerateRandomMagical()
        {
            //assigns random values to each attribute of this object
        }

        public override string ToString()
        {
            //returns a string that makes more sense with the class
            return base.ToString();
        }
    }
}
