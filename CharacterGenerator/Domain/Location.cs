using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Location
    {
        public string Title { get; set; }
        public string InhabitantsPrimaryRace { get; set; }
        public string Region { get; set; }
        public char RelativeMapPosition { get; set; } //N, S, E, or W
        public bool FreeLand { get; set; }

        public Location()
        {
            //generate random location
        }

        public void GenerateRandomLocation()
        {
            //assign random values to each class attribute
        }

        public override string ToString()
        {
            //return a string that makes more sense with Location Class
            return base.ToString();
        }

    }
}
