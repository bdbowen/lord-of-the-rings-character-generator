using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;
namespace CharacterGenerator
{
    public class HobbitLogic
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud
        public static int MAXAGE = 150;

        public Hobbit GetHobbit(int hobbitID)
        {
            var hobbit = context.Hobbits.Find(hobbitID);
            return hobbit;
        }
        public IEnumerable<Hobbit> GetAllHobbits()
        {
            var hobbits = context.Hobbits.ToList();
            return hobbits;
        }
        public void AddHobbit(Hobbit myHobbit)
        {
            context.Hobbits.Add(myHobbit);
            context.SaveChanges();
        }

        public void UpdateHobbit()
        {
            context.SaveChanges();
        }

        public void DeleteHobbit(Hobbit myHobbit)
        {
            context.Hobbits.Remove(myHobbit);
            context.SaveChanges();
        }
        public List<Physical> PhysicalAbilities { get; } = new List<Physical>();

        //data for randomization
        public static string[] MaleFirstNames = new string[] { "Frodo", "Bilbo", "Samwise", "Perigrin", "Lotho", "Radigis", "Ramnulf", "Humbert",
            "Balbo", "Ceufroy", "Taurin", "Clovis", "Theodoric", "Sigismond", "Wolbodo"};
        public static string[] FemaleFirstNames = new string[] { "Lobellia", "Mariah", "Arabella", "Angela", "Faileuba", "Eadgithu", "Sydney",
            "Adele", "Pervinca", "Basina", "Rotrude", "Cassandra"};
        public static string[] LastNames = new string[] {"Took", "Baggins", "Brandybuck", "Proudfoot", "Sackville", "Sackville-Baggins", "Gamgee",
        "Boffin", "Bolger", "Bracegirdle", "Burrowes", "Chubb", "Grubb", "Hornblower", "Sandyman", "Underhill"};
        public static string[] HomeTypeOptions = new string[] { "Hobbit Hole", "Above Ground House" };
        //constructors

        public Hobbit GenerateRandomHobbit(int numberOfAbilities, Random rand)
        {
            PersonLogic personLogic = new PersonLogic();
            Person person = personLogic.GenerateRandomPerson(rand.Next(1, 10), "hobbit", rand);
            Hobbit hobbit = new Hobbit();
            person.RaceType = "Hobbit";
            int index;

            //set Name
            person.Name = GenerateHobbitName(person.Gender, rand);

            //reset age
            person.Age = rand.Next(1, MAXAGE);

            //reset position
            person.LengthOfRoleOccupancy = rand.Next(1, person.Age);

            //set Home type
            index = rand.Next(0, HomeTypeOptions.Length);
            hobbit.HomeType = HomeTypeOptions[index];

            //set Booleans
            hobbit.OwnsOneRing = rand.Next(2) == 1;
            hobbit.IsAdventurer = rand.Next(2) == 1;

            //set abilities - future
            /*for (int i = 0; i < numberOfAbilities; i++)
            {
                PhysicalAbilities.Add(new Physical(rand));
            }*/
            personLogic.UpdatePerson();
            hobbit.PersonID = person.PersonID;
            AddHobbit(hobbit);
            return hobbit;
        }

        public static string GenerateHobbitName(string gender, Random rand)
        {
            string firstName, lastName;
            int index;
            if (gender.ToLower() == "f")
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
