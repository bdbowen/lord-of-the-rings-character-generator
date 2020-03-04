using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Location
    {
        public string Title { get; set; }
        private string inhabitantsPrimaryRace;
        public string InhabitantsPrimaryRace
        {
            get { return inhabitantsPrimaryRace; }
            set
            {
                if (Array.IndexOf(RaceOptions, value) > -1)
                {
                    inhabitantsPrimaryRace = value;
                }
                else
                {
                    throw new Exception("Please choose one of the races: elf, hobbit, dwarf, human or wizard for the primary race");
                }
            }
        }
        public string Region { get; set; }
        public char RelativeMapPosition { get; set; } //N, S, E, or W
        public bool FreeLand { get; set; }

        //generic data to initialize with
        public static string[] RaceOptions = new string[] { "Elf", "Dwarf", "Hobbit", "Wizard", "Human" };

        public static string[] RegionOptions = new string[] { "Shire", "Gondor", "Rohan", "Mordor", "Rhovanion", "The Misty Mountains and Surroundings", "Rhun", "Belarian" };
        public static Dictionary<string, string[]> LocationByRegion = new Dictionary<string, string[]>()
        {
            {"Shire", new string[] {"Hobbiton", "Buckland", "Mickel Delving", "Bree" } },
            {"Gondor", new string[] {"Osgiliath", "Minas Tirith"} },
            {"Rohan", new string[] {"Edoras", "Helm's Deep", "Eisengard", "Fanghorn Forest", "Dunland"} },
            {"Mordor", new string[] {"Barad-dur", "Minas Morgul"} },
            {"Rhovanion", new string[] {"Mirkwood Forest", "Erebor", "Esgaroth", "Dol Guldur"} },
            {"The Misty Mountains and Surroundings", new string[] {"Rivendell", "The Mines of Moria", "Lothlorien"} },
            {"Rhun", new string[] {"The Iron Hills" } },
            {"Belarian", new string[] {"Angband", "Gondolin", "Angmar" } }
        };
        public static Dictionary<string, string> RaceByLocation = new Dictionary<string, string>
        {
            {"Hobbiton", "Hobbit" },
            {"Buckland", "Hobbit" },
            {"Mickel Delving", "Hobbit" },
            {"Bree", "Human" },
            {"Osgiliath", "Human" },
            { "Minas Tirith", "Human" },
            {"Edoras", "Human" },
            { "Helm's Deep", "Human" },
            { "Eisengard", "Wizard" },
            { "Fanghorn Forest", "Wizard" },
            {"Barad-dur", "Wizard" },
            { "Minas Morgul", "Human" },
            {"Mirkwood Forest", "Elf" },
            { "Erebor", "Dwarf" },
            { "Esgaroth", "Man" },
            { "Dol Guldur", "Wizard" },
            {"Rivendell", "Elf"},
            { "The Mines of Moria", "Dwarf" },
            { "Dunland", "Human" },
            { "Lothlorien", "Elf" },
            {"The Iron Hills", "Dwarf" },
            { "Angband", "Wizard" },
            { "Gondolin", "Elf" },
            { "Angmar", "Human"}
        };

        public Location()
        {
            GenerateRandomLocation();
        }

        public void GenerateRandomLocation()
        {
            Random rand = new Random();
            int index = 0;
            //Set Region
            index = rand.Next(0, RegionOptions.Length);
            Region = RegionOptions[index];

            //Set Title
            string[] locationOptions = LocationByRegion[Region];
            index = rand.Next(0, locationOptions.Length);
            Title = locationOptions[index];
            //Set InhabitantPrimaryRace
            InhabitantsPrimaryRace = RaceByLocation[Title];
            
            //Set Map Location
            char[] cardinalDirections = new char[] { 'N', 'S', 'E', 'W' };
            index = rand.Next(0, cardinalDirections.Length);
            RelativeMapPosition = cardinalDirections[index];

            //set free land randomly
            FreeLand = rand.Next(2) == 1;
        }

        public override string ToString()
        {
            string classString = "Location: " + Title + "\n Region of Middle Earth: " + Region + "\n Primary Race of Location: " + InhabitantsPrimaryRace +
                "\n Quadrant of Map: " + RelativeMapPosition.ToString() + "\n Free Land: " + FreeLand.ToString();
            return classString;
        }

    }
}
