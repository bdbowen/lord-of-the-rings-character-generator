using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;
namespace CharacterGenerator
{
    public class HumanLogic : IGenerate<Human>
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud

        public Human GetHuman(int humanID)
        {
            var human = context.Humans.Find(humanID);
            return human;
        }
        public IEnumerable<Human> GetAllHumans()
        {
            var humans = context.Humans.ToList();
            return humans;
        }
        public void AddHuman(Human myHuman)
        {
            context.Humans.Add(myHuman);
            context.SaveChanges();
        }

        public void UpdateHuman()
        {
            context.SaveChanges();
        }

        public void DeleteHuman(Human myHuman)
        {
            context.Humans.Remove(myHuman);
            context.SaveChanges();
        }
        //class attributes
        public static int MAXAGE = 100;


        //data for randomization
        public static string[] MaleFirstNames = new string[] { "Theodred", "Aragorn", "Arathorn", "Boromir", "Faramir", "Denathor", "Beren", "Eomer", "Theoden",
        "Engal", "Luk-Vohpiod", "Jilmendek", "Eavien", "Rothimzic", "Orvildien", "Stalcor"  };
        public static string[] FemaleFirstNames = new string[] { "Eowyn", "Cielle", "Lua", "Betj", "Lezeelzel", "Hihruvel", "Kafare", "Eeroh", "Jeim", "Lia",
            "Mai", "Jei", "Mi", "Jhairrunill"};
        public static string[] LastNames = new string[] {"Rhehlon", "Morketsk", "Zoltanzefk", "Gendadrin", "Mao", "Duulueltrab", "Stiknuz", "Binzelbul",
            "Gryedabyevu", "Horazor","Gendilbo", "Nen"  };
        public static string[] AncestralLineOptions = new string[] {"Dunadain", "Black Numenorians", "Haradrim", "Easterlings", "Northmen", "Dunlendings",
            "Druedain"};
        public Human Generate(Random rand, int numberOfPhysical, int numberOfMental, int numberOfMagical = 0)
        {
            PersonLogic personLogic = new PersonLogic();

            Human human = (Human)personLogic.Generate("men", rand, new Human());
            human.RaceType = "men";
            int index;
            //set name
            human.Name = GenerateName(human.Gender, rand);

            //reset age
            human.Age = rand.Next(1, MAXAGE);

            //set Position
            human.LengthOfRoleOccupancy = rand.Next(1, human.Age);

            //set ancestral line
            index = rand.Next(0, AncestralLineOptions.Length);
            human.AncestralLine = AncestralLineOptions[index];

            AddHuman(human);

            personLogic.GenerateAdventures(human.PersonID, rand.Next(1,10), rand);
            return human;
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
