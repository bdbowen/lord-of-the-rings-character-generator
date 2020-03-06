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
        public string SkinComplexion { get; set; }
        private string gender;
        public string Gender { get { return gender; } 
            set { 
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new Exception("Gender must be either 'male' or 'female'!");
                } else
                {
                    gender = value;
                }
            } 
        }

        //Other important information
        public Location HomeTown { get; set; }
        public Role Position { get; set; }
        public List<Adventure> Adventures { get; } = new List<Adventure>();
        public string WeaponOfChoice { get; set; }
        public bool Evil { get; set; }

        //random data
        public static string[] HairColorOptions = new string[] { "Black", "Dark Brown", "Light Brown", "Brown", "Auburn", "Golden Blonde", "Blonde", "Red", 
            "Silver Grey", "Silver", "Golden Brown", "Light Blonde", "Strawberry Blonde", "Dark Auburn", "Gray", "White", "Platinum Blonde", "Black with Gray"};
        public static string[] EyeColorOptions = new string[] { "Amber", "Blue", "Brown", "Gray", "Green", "Hazel", "Violet", "Red"  };
        public static string[] SkinComplexionOptions = new string[] { "Fair", "Light", "Medium", "Dark", "Very Dark", "Deep"};
        public static string[] WeaponOfChoiceOptions = new string[] { "Sword", "Knife", "Dagger", "Axe", "Bow", "Staff", "Slingshot", "Crossbow", "Mace", 
            "Ring of Power"};


        //Constructors
        public Person()
        {
            Random rand = new Random();
            GenerateRandomPerson(rand.Next(1, 5));
        }
        public Person(int numberOfAdventures)
        {
            GenerateRandomPerson(numberOfAdventures);
        }

        public Person(int numberOfAdventures, int maxAge, string[] firstNameOptions, string[] lastNameOptions)
        {
            //to be used mainly with Person's sub classes, this allows more control of randomization
            //that way a wizard name sounds more wizardly and a human name sounds more human 
            //and age is more logical - you don't get a 2000 year old human
        }

        public void GenerateRandomPerson(int numberOfAdventures)
        {
            Random rand = new Random();
            int index = 0;
            //Let Name be set by subclass
            //Randomize Age
            Age = rand.Next(1, 10000);

            //Randomize Hair Color
            index = rand.Next(0, HairColorOptions.Length);
            HairColor = HairColorOptions[index];

            //Randomize Eye Color
            index = rand.Next(0, EyeColorOptions.Length);
            EyeColor = EyeColorOptions[index];

            //Randomize Complection
            index = rand.Next(0, SkinComplexionOptions.Length);
            SkinComplexion = SkinComplexionOptions[index];

            //Gender
            Gender = rand.Next(2) == 1 ? "male" : "female";

            //Hometown
            HomeTown = new Location();

            //Position
            Position = new Role(Gender, Age);

            //Adventures
            for (int i = 0; i < numberOfAdventures; i ++)
            {
                Adventure adventure = new Adventure();
                Adventures.Add(adventure);
            }

            //Weapon of Choice
            index = rand.Next(0, WeaponOfChoiceOptions.Length);
            WeaponOfChoice = WeaponOfChoiceOptions[index];

            //Evil 
            Evil = rand.Next(2) == 1;
        }

        public override string ToString()
        {
            string adventures = "";
            foreach(Adventure adventure in Adventures)
            {
                adventures += adventure.ToString() + "\n";
            }
            string classString = "Name: " + Name + "\nAge: " + Age + "\nGender: " + Gender + "\nHair Color: " + HairColor + "\nEye Color: " + EyeColor +
                "\nSkin Tone: " + SkinComplexion + "\nHometown: " + HomeTown.ToString() + "\nPosition: " + Position.ToString() + "\nEvil: " + Evil.ToString() +
                "\nWeapon of Choice: " + WeaponOfChoice + "\nAdventures: " + adventures;
            return classString;
        }
    }
}
