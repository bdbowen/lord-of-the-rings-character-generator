using System;

namespace CharacterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Role myRole = new Role();
            Role myMaleRole = new Role("male");
            Role myFemaleRole = new Role("female", 100);
            Console.WriteLine("Neutral:\n {0}", myRole);
            Console.WriteLine("Male:\n {0}", myMaleRole);
            Console.WriteLine("Female:\n {0}", myFemaleRole);

        }
    }
}
