using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Role
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PrimaryRace { get; set; }
        public int NumberOfSubordinates { get; set; }
        public int LenthOfOccupancy { get; set; }
        public bool SupremeRole { get; set; }

        public Role()
        {
            //generate random role instance
        }

        public void GenerateRandomRole()
        {
            //assigns random values to each class attribute
        }

        public override string ToString()
        {
            //return a more logical string to fit with the Role class
            return base.ToString();
        }
    }
}
