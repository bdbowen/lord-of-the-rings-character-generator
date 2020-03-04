using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CharacterGenerator
{
    class Adventure
    {
        public string LeaderName { get; set; }
        public Location WhereTo { get; set; }
        public ArrayList CompanionNames { get; } = new ArrayList();
        public bool Successful { get; set; }
        public bool Fatal { get; set; }

        //constructors
        public Adventure()
        {
            Random rand = new Random();
            GenerateRandomAdventure(rand.Next(0, 20));
        }

        public Adventure(int numberOfCompanions)
        {
            GenerateRandomAdventure(numberOfCompanions);
        }

        public void GenerateRandomAdventure(int numberOfCompanions)
        {
            Random rand = new Random();

            //randomly assign leader 
            LeaderName = Wizard.GenerateWizardName(rand.Next(2) == 1 ? "female" : "male");

            //set WhereTo
            WhereTo = new Location();

            for(int i = 0; i<numberOfCompanions; i ++)
            {
                int randomNum = rand.Next(1, 5);
                string gender = rand.Next(2) == 1 ? "female" : "male";
                if (randomNum == 1)
                {
                    CompanionNames.Add(Hobbit.GenerateHobbitName(gender));

                } else if (randomNum == 2)
                {
                    CompanionNames.Add(Elf.GenerateElfName(gender));

                } else if (randomNum == 3)
                {
                    CompanionNames.Add(Dwarf.GenerateDwarfName(gender));
                } else if (randomNum == 4)
                {
                    CompanionNames.Add(Human.GenerateHumanName(gender));

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
            string lastCompanion = (string) CompanionNames[CompanionNames.Count - 1];
            foreach (string companion in CompanionNames)
            {
                if (companion != lastCompanion)
                {
                    companions += companion + ", ";
                } else
                {
                    companions += companion;
                }
            }
            string classString = "Leader: " + LeaderName + "\n\nCompanions: " + companions + "\n\nAdventure Destination: \n" + WhereTo.ToString() + "\n\nSuccessful: " +
                Successful + "\n\nFatal: " + Fatal;
            return classString;
        }
    }
}
