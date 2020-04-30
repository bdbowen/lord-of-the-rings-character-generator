using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;
namespace CharacterGenerator
{
    public class AdventureLogic
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud
        public Adventure GetAdventure(int id)
        {
            var adventure = context.Adventures.Find(id);
            return adventure;
        }
        public IEnumerable<Adventure> GetAllAdventures()
        {
            var adventures = context.Adventures.ToList();
            return adventures;
        }
        public void AddAdventure(Adventure myAdventure)
        {
            context.Adventures.Add(myAdventure);
            context.SaveChanges();
        }

        public void UpdateAdventure()
        {
            context.SaveChanges();
        }

        public void DeleteAdventure(Adventure myAdventure)
        {
            context.Adventures.Remove(myAdventure);
            context.SaveChanges();
        }
        public Adventure Generate(int numberOfCompanions, int personID, Random rand)
        {
            Adventure adventure = new Adventure();
            ElfLogic elfLogic = new ElfLogic();
            DwarfLogic dwarfLogic = new DwarfLogic();
            HobbitLogic hobbitLogic = new HobbitLogic();
            HumanLogic humanLogic = new HumanLogic();
            WizardLogic wizardLogic = new WizardLogic();

            List<string> CompanionNames = new List<string>();
            //randomly assign leader 
            adventure.LeaderName = wizardLogic.GenerateName(rand.Next(2) == 1 ? "female" : "male", rand);

            LocationLogic locationLogic = new LocationLogic();
            IEnumerable<Location> locations = locationLogic.GetAllLocations();
            int index = rand.Next(0, locations.Count());
            //set WhereTo
            adventure.WhereToLocationID = locations.ElementAt(index).LocationID;
            
            for (int i = 0; i < numberOfCompanions; i++)
            {
                int randomNum = rand.Next(1, 5);
                string gender = rand.Next(2) == 1 ? "female" : "male";
                string name;
                if (randomNum == 1)
                {
                    name = hobbitLogic.GenerateName(gender, rand);

                    while (CompanionNames.Contains(name))
                    {
                        name = hobbitLogic.GenerateName(gender, rand);
                    }
                    CompanionNames.Add(name);
                }
                else if (randomNum == 2)
                {
                    name = elfLogic.GenerateName(gender, rand);

                    CompanionNames.Add(name);

                }
                else if (randomNum == 3)
                {
                    name = dwarfLogic.GenerateName(gender, rand);

                    CompanionNames.Add(name);
                }
                else if (randomNum == 4)
                {
                    name = humanLogic.GenerateName(gender, rand);

                    CompanionNames.Add(name);
                }
                
            }
            
            //set Successful
            adventure.Successful = rand.Next(2) == 1;

            //set fatal - fatal cannot be true if successful is true because a successful adventure cannot be fatal, but a unsuccessful mission could be fatal, but doesn't have to be
            adventure.Fatal = adventure.Successful ? false : rand.Next(2) == 1;
            if (adventure.Fatal)
            {
                bool leaderDead = rand.Next(2) == 1;
                char deathDagger = (char)8224;
                adventure.LeaderName = leaderDead ? adventure.LeaderName + deathDagger : adventure.LeaderName;
                int numDeadCompanions = leaderDead ? rand.Next(CompanionNames.Count()) : rand.Next(0, CompanionNames.Count());
                List<int> usedIndexes = new List<int>();
                for (int i = 0; i < numDeadCompanions; i ++)
                {
                    do
                    {
                        index = rand.Next(CompanionNames.Count());
                    } while (usedIndexes.Contains(index));
                    usedIndexes.Add(index);
                    CompanionNames[index] = CompanionNames[index] + deathDagger;
                }
            }
            adventure.CompanionNames = string.Join(",", CompanionNames);
            adventure.MainPersonID = personID;
            AddAdventure(adventure);
            return adventure;
        }
    }
}
