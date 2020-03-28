using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;

namespace CharacterGenerator
{
    public class DwarfLogic
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud
        public Dwarf GetDwarf(int dwarfID)
        {
            var dwarf = context.Dwarves.Find(dwarfID);
            return dwarf;
        }
        public IEnumerable<Dwarf> GetAllDwarves()
        {
            var dwarves = context.Dwarves.ToList();
            return dwarves;
        }
        public void AddDwarf(Dwarf myDwarf)
        {
            context.Dwarves.Add(myDwarf);
            context.SaveChanges();
        }

        public void UpdateDwarf()
        {
            context.SaveChanges();
        }

        public void DeleteDwarf(Dwarf myDwarf)
        {
            context.Dwarves.Remove(myDwarf);
            context.SaveChanges();
        }
        //Class Attributes
        public static int MAXAGE = 250;
        public List<Physical> PhysicalAbilities { get; } = new List<Physical>();
        public List<Mental> FieldsOfWisdom { get; } = new List<Mental>();

        //data for randomization
        public static string[] MaleFirstNames = new string[] { "Gimli", "Thorin", "Thrain", "Thror", "Fili", "Kili", "Bifur", "Bofur", "Bombur", "Oin",
            "Gloin", "Balin", "Dwalin",  "Kraroud", "Darezil", "Gogheag", "Halgaem", "Yudgrour", "Whugnur"};
        public static string[] FemaleFirstNames = new string[] { "Jalmibo", "Umimrire", "Jakdrostr", "Lozuhilda", "Betgrehilda", "Debuna", "Skasoni", "Adgaren",
            "Bomnelyn", "Nakhibena", "Nedwealin", "Fobeabo", "Throghaelda"};
        public static string[] LastNames = new string[] { "Kegmaster", "Onyxmace", "Marbleblender", "Bitterchest", "Mithriltoe", "Grimbringer", "Frostmail",
            "Metalbow", "Kragbuster", "Blackarm", "Oakenshield", "Fieryflayer", "Emberspine" };
        public static string[] DwarfGroupOptions = new string[] {"Belegost Dwarf", "Erebor Dwarf", "Khazad-dum Dwarf", "Nogrod Dwarf", "Blue Mountain Dwarf",
        "Grey Mountain Dwarf", "Iron Hill Dwarf"};
        //constructors

        public Dwarf GenerateRandomDwarf(int numberOfPhysical, int numberOfMental, Random rand)
        {
            PersonLogic personLogic = new PersonLogic();
            Person person = personLogic.GenerateRandomPerson(rand.Next(1,10), "dwarf", rand);
            Dwarf dwarfPerson = new Dwarf();
            
            person.RaceType = "dwarf";
            int index;
            //set name
            person.Name = GenerateDwarfName(person.Gender, rand);

            //reset age
            person.Age = rand.Next(1, MAXAGE);

            //reset position
            person.LengthOfRoleOccupancy = rand.Next(1, person.Age);

            //set DwarfFamily
            index = rand.Next(0, DwarfGroupOptions.Length);
            dwarfPerson.DwarfGroup = DwarfGroupOptions[index];
            dwarfPerson.PersonID = person.PersonID;
            AddDwarf(dwarfPerson);
            personLogic.UpdatePerson();
            //set abilities -> future
            /*for (int i = 0; i < numberOfPhysical; i++)
            {
                PhysicalAbilities.Add(new Physical(rand));
            }
            for (int i = 0; i < numberOfMental; i++)
            {
                FieldsOfWisdom.Add(new Mental(rand));
            }
            */
            return dwarfPerson;
        }

        public static string GenerateDwarfName(string gender, Random rand)
        {
            string firstName, lastName;
            int index;
            if (gender.ToLower() == "female")
            {
                index = rand.Next(0, FemaleFirstNames.Length);
                firstName = FemaleFirstNames[index];
            }
            else
            {
                index = rand.Next(0, MaleFirstNames.Length);
                firstName = MaleFirstNames[index];
            }
            index = rand.Next(0, LastNames.Length);
            lastName = LastNames[index];

            return firstName + " " + lastName;
        }
    }
}
