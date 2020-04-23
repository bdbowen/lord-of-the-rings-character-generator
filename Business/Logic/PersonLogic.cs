using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;
namespace CharacterGenerator
{
    public class PersonLogic
    {

        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud
        public Person GetPerson(int personID)
        {
            var person = context.Persons.Find(personID);
            return person;
        }
        public IEnumerable<Person> GetAllPersons()
        {
            var persons = context.Persons.ToList();
            return persons;
        }
        public void AddPerson(Person myPerson)
        {
            context.Persons.Add(myPerson);
            context.SaveChanges();
        }

        public void UpdatePerson()
        {
            context.SaveChanges();
        }

        public void DeletePerson(Person myPerson)
        {
            context.Persons.Remove(myPerson);
            context.SaveChanges();
        }
        //random data
        public static string[] HairColorOptions = new string[] { "Black", "Dark Brown", "Light Brown", "Brown", "Auburn", "Golden Blonde", "Blonde", "Red",
            "Silver Grey", "Silver", "Golden Brown", "Light Blonde", "Strawberry Blonde", "Dark Auburn", "Gray", "White", "Platinum Blonde", "Black with Gray"};
        public static string[] EyeColorOptions = new string[] { "Amber", "Blue", "Brown", "Gray", "Green", "Hazel", "Violet", "Red" };
        public static string[] SkinComplexionOptions = new string[] { "Fair", "Light", "Medium", "Dark", "Very Dark", "Deep" };
        public static string[] WeaponOfChoiceOptions = new string[] { "Sword", "Knife", "Dagger", "Axe", "Bow", "Staff", "Slingshot", "Crossbow", "Mace",
            "Ring of Power"};


        
        public Person GenerateRandomPerson(int numberOfAdventures, string raceType, Random rand)
        {
            int index;
            Person person = new Person();
            //Let Name be set by subclass
            person.Name = "n/a";
            //Randomize Age
            person.Age = rand.Next(1, 10000);
            person.RaceType = raceType;
            //Randomize Hair Color
            index = rand.Next(0, HairColorOptions.Length);
            person.HairColor = HairColorOptions[index];

            //Randomize Eye Color
            index = rand.Next(0, EyeColorOptions.Length);
            person.EyeColor = EyeColorOptions[index];

            //Randomize Complection
            index = rand.Next(0, SkinComplexionOptions.Length);
            person.SkinComplexion = SkinComplexionOptions[index];

            //Gender
            person.Gender = rand.Next(2) == 1 ? "M" : "F";

            List<Location> locations = context.Locations.ToList();
            index = rand.Next(1, locations.Count());
            //Hometown
            person.HomeTownLocationID = locations.ElementAt(index).LocationID;

            //eventually filter by gender and by race type
            List < Role > roles =  context.Roles.Where(c => c.GenderRole == person.Gender && c.PrimaryRace == raceType).ToList();
            index = rand.Next(1, roles.Count());
            //Position
            person.PositionRoleID = roles.ElementAt(index).RoleID;
            person.LengthOfRoleOccupancy = rand.Next(1, person.Age);
            person.NumberOfSubordinates = rand.Next();
            //Adventures

            int incrementValue = rand.Next();
            AdventureLogic adventure = new AdventureLogic();
            
            //Weapon of Choice
            index = rand.Next(0, WeaponOfChoiceOptions.Length);
            person.WeaponOfChoice = WeaponOfChoiceOptions[index];

            //Evil 
            person.Evil = rand.Next(2) == 1;

            AddPerson(person);
            for (int i = 0; i < numberOfAdventures; i++)
            {
                adventure.GenerateRandomAdventure(rand.Next(1, 20), person.PersonID, rand);
            }

            return person;

        }
    }
}
