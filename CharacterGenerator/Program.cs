using System;

namespace CharacterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to generate a location or role?");
            string input = Console.ReadLine().ToLower();
            if (input == "location")
            {
                for (int i=0; i<5; i++)
                {
                    Location myLocation = new Location();
                    Console.WriteLine("Location:\n {0}\n", myLocation);

                }
            } else if (input == "role")
            {
                Role myRole = new Role();
                Role myMaleRole = new Role("male");
                Role myFemaleRole = new Role("female", 100);
                Console.WriteLine("Neutral:\n {0}", myRole);
                Console.WriteLine("Male:\n {0}", myMaleRole);
                Console.WriteLine("Female:\n {0}", myFemaleRole);
            } else
            {
                Console.WriteLine("Not an option, Have a nice day!");
            }

        }
    }
}
