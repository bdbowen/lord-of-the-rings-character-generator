using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;
namespace CharacterGenerator
{
    public class ElfLogic : IGenerate<Elf>
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

        //data for randomization
        public static string[] MaleFirstNames = new string[] {"Elrond", "Mithrandir", "Sylvan", "Legolas", "Glorfindel", "Gildor", "Elrohir", "Thranduil", "Elkhazel",
            "Folas", "Mellon", "Almon", "Halamar", "Falael", "Tarasael","Hilerael"};
        public static string[] FemaleFirstNames = new string[] { "Galadriel", "Tauriel", "Arwen", "Luthien", "Aiwin", "Aymar", "Myrin", "Elisen", "Lethhonel", "Naesala",
            "Zentha", "Kenia", "Ialantha" };
        public static string[] LastNames = new string[] { "Oriric", "Facaryn", "Inglorien", "Valran", "Kelsalor", "Xilfir", "Daecaryn", "Greenleaf", "Gregeiros",
            "Beiquinal", "Shomar" };
        public static string[] ElfTypeOptions = new string[] { "Vanyar", "Noldor", "Teleri", "Avari", "Sindar", "Nandor - Silvan", "Nandor - Laiquendi", "Avari" };

        //constructors
        public Elf Generate(Random rand, int numberOfPhysical, int numberOfMental, int numberOfMagical)
        {
            PersonLogic personLogic = new PersonLogic();
            Elf elfPerson = (Elf) personLogic.Generate("elf", rand, new Elf());

            elfPerson.RaceType = "elf";
            int index;
            //set Elf
            elfPerson.Name = GenerateName(elfPerson.Gender, rand);
            
            //set Elf Type
            index = rand.Next(0, ElfTypeOptions.Length);
            elfPerson.ElfType = ElfTypeOptions[index];

            //set owns ring of power
            elfPerson.OwnsRingOfPower = rand.Next(2) == 1;

            AddElf(elfPerson);
            personLogic.GenerateAdventures(elfPerson.PersonID, rand.Next(1, 10), rand);

            return elfPerson;
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
        public static Elf ConvertToElf(Person person)
        {
            Elf elf = new Elf();
            elf.Name = person.Name;
            elf.Age = person.Age;
            elf.RaceType = person.RaceType;
            elf.HairColor = person.HairColor;
            elf.EyeColor = person.EyeColor;
            elf.SkinComplexion = person.SkinComplexion;
            elf.Gender = person.Gender;
            elf.HomeTownLocationID = person.HomeTownLocationID;
            elf.PositionRoleID = person.PositionRoleID;
            elf.LengthOfRoleOccupancy = person.LengthOfRoleOccupancy;
            elf.NumberOfSubordinates = person.NumberOfSubordinates;
            elf.WeaponOfChoice = person.WeaponOfChoice;
            elf.Evil = person.Evil;

            return elf;
        }
    }
}
