using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;
namespace CharacterGenerator
{
    public class HobbitLogic : IGenerate<Hobbit>
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

        //data for randomization
        public static string[] MaleFirstNames = new string[] { "Frodo", "Bilbo", "Samwise", "Perigrin", "Lotho", "Radigis", "Ramnulf", "Humbert",
            "Balbo", "Ceufroy", "Taurin", "Clovis", "Theodoric", "Sigismond", "Wolbodo"};
        public static string[] FemaleFirstNames = new string[] { "Lobellia", "Mariah", "Arabella", "Angela", "Faileuba", "Eadgithu", "Sydney",
            "Adele", "Pervinca", "Basina", "Rotrude", "Cassandra"};
        public static string[] LastNames = new string[] {"Took", "Baggins", "Brandybuck", "Proudfoot", "Sackville", "Sackville-Baggins", "Gamgee",
        "Boffin", "Bolger", "Bracegirdle", "Burrowes", "Chubb", "Grubb", "Hornblower", "Sandyman", "Underhill"};
        public static string[] HomeTypeOptions = new string[] { "Hobbit Hole", "Above Ground House" };
        //constructors

        public Hobbit Generate(Random rand, int numberOfAbilities, int numberOfMagical = 0, int numberOfMental = 0)
        {
            PersonLogic personLogic = new PersonLogic();

            Hobbit hobbit = (Hobbit)personLogic.Generate("hobbit", rand, new Hobbit());
            hobbit.RaceType = "Hobbit";
            int index;

            //set Name
            hobbit.Name = GenerateName(hobbit.Gender, rand);

            //reset age
            hobbit.Age = rand.Next(1, MAXAGE);

            //reset position
            hobbit.LengthOfRoleOccupancy = rand.Next(1, hobbit.Age);

            //set Home type
            index = rand.Next(0, HomeTypeOptions.Length);
            hobbit.HomeType = HomeTypeOptions[index];

            //set Booleans
            hobbit.OwnsOneRing = rand.Next(2) == 1;
            hobbit.IsAdventurer = rand.Next(2) == 1;

            AddHobbit(hobbit);

            personLogic.GenerateAdventures(hobbit.PersonID, rand.Next(1,10), rand);
            return hobbit;
        }

        public string GenerateName(string gender, Random rand)
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
