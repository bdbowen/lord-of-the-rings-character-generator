using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Mental : Ability
    {
        public string RaceOfOrigin { get; set; }
        public Location SchoolLocation { get; set; }
        public bool RequiresSubjectMastery { get; set; }

        public Mental()
        {
            //generates random Mental object
        }

        public void GenerateRandomMental()
        {
            //assigns random values to each class attribute
        }
        public override string ToString()
        {
            //return a string that makes more sense for the Mental class
            return base.ToString();
        }
    }
}
