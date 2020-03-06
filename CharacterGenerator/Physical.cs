using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class Physical : Ability
    {
        public string ToolRequired { get; set; }
        public string RaceOfOrigin { get; set; }
        public Location TrainingLocation { get; set; }
        public bool Fighting { get; set; }
        public bool Lethal { get; set; }
        public bool RequiresWeaponMastery { get; set; }

        public Physical()
        {
            //generate random Physical object
        }

        public void GenerateRandomPhysical()
        {
            //assigns random values to each of the class attributes
        }
        public override string ToString()
        {
            //return a string that makes more sense with the Physical class
            return base.ToString();
        }
    }

}
