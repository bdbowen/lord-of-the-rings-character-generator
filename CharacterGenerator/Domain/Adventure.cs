using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Adventure
    {
        public string LeaderName { get; set; }
        public Location WhereTo { get; set; }
        public string[] CompanionNames { get; set; }
        public bool Successful { get; set; }
        public bool Fatal { get; set; }

        //constructors
        public Adventure()
        {
            //Generate a random Adventure with a random number of companions
        }

        public Adventure(int numberOfCompanions)
        {
            //generate a random Adventure with set number of Adventures
        }
        public void GenerateRandomAdventure(int numberOfCompanions)
        {
            //randomly assign each variable a value
        }
        public override string ToString()
        {
            //return a more logical string with the class
            return base.ToString();
        }
    }
}
