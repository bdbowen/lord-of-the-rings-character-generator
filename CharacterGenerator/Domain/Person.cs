using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator
{
    class Person
    {
        // Person Class Attributes
        // TODO: Define each getter and setter for proper error checking
        //Physical Characteristics
        public string Name { get; set; }
        public int Age { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string SkinComplection { get; set; }
        public char Gender { get; set; }

        //Other important information
        public Location HomeTown { get; set; }
        public Role Position { get; set; }
        public Adventure[] Adventures { get; }
        public string WeaponOfChoice { get; set; }
        public bool Evil { get; set; }

        //Constructors
        public Person()
        {
            //generates random person with random number of adventures
        }
        public Person(int numberOfAdventures)
        {
            //calls generate random person with specific number of adventures
        }

        public Person(int numberOfAdventures, int maxAge, string[] firstNameOptions, string[] lastNameOptions)
        {
            //to be used mainly with Person's sub classes, this allows more control of randomization
            //that way a wizard name sounds more wizardly and a human name sounds more human 
            //and age is more logical - you don't get a 2000 year old human
        }

        public void AddAdventure(Adventure newAdventure)
        {
            //Add a new adventure to the adventures array
        }

        public void GenerateRandomPerson(int numberOfAdventures)
        {
            //randomly assign values to each of the attributes of person
        }

        public override string ToString()
        {
            //change to return each attribute of this class in a logical way
            return base.ToString();
        }
    }
}
