using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;
namespace CharacterGenerator
{
    public class ElfLogic
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud
        public Elf GetElf(int elfID)
        {
            var elf = context.Elves.Find(elfID);
            return elf;
        }
        public IEnumerable<Elf> GetAllElves()
        {
            var elves = context.Elves.ToList();
            return elves;
        }
        public void AddElf(Elf myElf)
        {
            context.Elves.Add(myElf);
            context.SaveChanges();
        }

        public void UpdateElf()
        {
            context.SaveChanges();
        }

        public void DeleteElf(Elf myElf)
        {
            context.Elves.Remove(myElf);
            context.SaveChanges();
        }
        //TODO: add error checking for all the getter and setter methods
        //Elf Attributes
        //Personal Information

        //Abilities
        /*public List<Mental> FieldsOfWisdom { get; } = new List<Mental>();
        public List<Physical> PhysicalAbilities { get; } = new List<Physical>();
        public List<Magical> MagicalFeats { get; } = new List<Magical>();*/

        //data for randomization
        public static string[] MaleFirstNames = new string[] {"Elrond", "Mithrandir", "Sylvan", "Legolas", "Glorfindel", "Gildor", "Elrohir", "Thranduil", "Elkhazel",
            "Folas", "Mellon", "Almon", "Halamar", "Falael", "Tarasael","Hilerael"};
        public static string[] FemaleFirstNames = new string[] { "Galadriel", "Tauriel", "Arwen", "Luthien", "Aiwin", "Aymar", "Myrin", "Elisen", "Lethhonel", "Naesala",
            "Zentha", "Kenia", "Ialantha" };
        public static string[] LastNames = new string[] { "Oriric", "Facaryn", "Inglorien", "Valran", "Kelsalor", "Xilfir", "Daecaryn", "Greenleaf", "Gregeiros",
            "Beiquinal", "Shomar" };
        public static string[] ElfTypeOptions = new string[] { "Vanyar", "Noldor", "Teleri", "Avari", "Sindar", "Nandor - Silvan", "Nandor - Laiquendi", "Avari" };

        //constructors
        public Elf GenerateRandomElf(int numberOfPhysical, int numberOfMental, int numberOfMagical, Random rand)
        {
            PersonLogic personLogic = new PersonLogic();
            Person person = personLogic.GenerateRandomPerson(rand.Next(1, 10), "elf", rand);
            Elf elfPerson = new Elf();

            person.RaceType = "elf";
            int index;
            //set Elf
            person.Name = GenerateElfName(person.Gender, rand);

            //set Elf Type
            index = rand.Next(0, ElfTypeOptions.Length);
            elfPerson.ElfType = ElfTypeOptions[index];

            //set owns ring of power
            elfPerson.OwnsRingOfPower = rand.Next(2) == 1;

            //set abilities -> future
            /*for (int i = 0; i < numberOfPhysical; i++)
            {
                PhysicalAbilities.Add(new Physical(rand));
            }

            for (int i = 0; i < numberOfMental; i++)
            {
                FieldsOfWisdom.Add(new Mental(rand));
            }

            for (int i = 0; i < numberOfMagical; i++)
            {
                MagicalFeats.Add(new Magical(rand));
            }*/

            personLogic.UpdatePerson();
            elfPerson.PersonID = person.PersonID;
            Console.WriteLine(person.PersonID);
            AddElf(elfPerson);
            return elfPerson;
        }

        public static string GenerateElfName(string gender, Random rand)
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
