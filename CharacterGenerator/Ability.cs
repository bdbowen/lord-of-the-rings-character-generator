using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class Ability
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int DifficultyLevel { get; set; }
        public bool Exhausting { get; set; }

        public Ability()
        {
            //generate random ability with random values for each attribute
        }

        public void GenerateRandomAbility()
        {
            //assigns random values to all of the class attributes
        }

        public override string ToString()
        {
            //return a string that makes more sense for the ability class
            return base.ToString();
        }
    }
}