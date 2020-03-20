using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    public class Adventure
    {
        public string LeaderName { get; set; }
        public Location WhereTo { get; set; }
        public List<string> CompanionNames { get; } = new List<string>();
        public bool Successful { get; set; }
        public bool Fatal { get; set; }

        //constructors
        public Adventure()
        {
            Random rand = new Random();
            GenerateRandomAdventure(rand.Next(0, 20), rand);
        }
        public Adventure(Random rand)
        {
            GenerateRandomAdventure(rand.Next(0, 20), rand);
        }

        public Adventure(int numberOfCompanions)
        {
            Random rand = new Random();
            GenerateRandomAdventure(numberOfCompanions, rand);
        }

        public void GenerateRandomAdventure(int numberOfCompanions, Random rand)
        {
            //randomly assign leader 
            LeaderName = Wizard.GenerateWizardName(rand.Next(2) == 1 ? "female" : "male", rand);

            //set WhereTo
            WhereTo = new Location(rand);

            for (int i = 0; i < numberOfCompanions; i++)
            {
                int randomNum = rand.Next(1, 5);
                string gender = rand.Next(2) == 1 ? "female" : "male";
                string name;
                if (randomNum == 1)
                {
                    name = Hobbit.GenerateHobbitName(gender, rand);

                    while (CompanionNames.Contains(name))
                    {
                        name = Hobbit.GenerateHobbitName(gender, rand);
                    }
                    CompanionNames.Add(name);
                }
                else if (randomNum == 2)
                {
                    name = Elf.GenerateElfName(gender, rand);

                    while (CompanionNames.Contains(name))
                    {
                        name = Elf.GenerateElfName(gender, rand);
                    }
                    CompanionNames.Add(name);

                }
                else if (randomNum == 3)
                {
                    name = Dwarf.GenerateDwarfName(gender, rand);

                    while (CompanionNames.Contains(name))
                    {
                        name = Dwarf.GenerateDwarfName(gender, rand);
                    }
                    CompanionNames.Add(name);
                }
                else if (randomNum == 4)
                {
                    name = Human.GenerateHumanName(gender, rand);

                    while (CompanionNames.Contains(name))
                    {
                        name = Human.GenerateHumanName(gender, rand);
                    }
                    CompanionNames.Add(name);
                }

            }

            //set Successful
            Successful = rand.Next(2) == 1;

            //set fatal - fatal cannot be true if successful is true because a successful adventure cannot be fatal, but a unsuccessful mission could be fatal, but doesn't have to be
            Fatal = Successful ? false : rand.Next(2) == 1;
        }
        public override string ToString()
        {
            string companions = "";
            foreach (string companion in CompanionNames)
            {
                if (CompanionNames.IndexOf(companion) != CompanionNames.Count - 1)
                {
                    companions += companion + ", ";
                }
                else
                {
                    companions += companion;
                }
            }
            string classString = "Leader: " + LeaderName + "\nCompanions: " + companions + "\nAdventure Destination: \n" + WhereTo.ToString() + "\nSuccessful: " +
                Successful + "\nFatal: " + Fatal;
            return classString;
        }
    }
}
