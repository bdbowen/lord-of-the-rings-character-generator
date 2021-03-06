﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;
//test change
namespace CharacterGenerator
{
    public class DwarfLogic : IGenerate<Dwarf>
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud
        public Dwarf GetDwarf(int dwarfID)
        {
            var dwarf = context.Dwarves.Find(dwarfID);
            return dwarf;
        }
        public IEnumerable<Dwarf> GetAllDwarves()
        {
            var dwarves = context.Dwarves.ToList();
            return dwarves;
        }
        public void AddDwarf(Dwarf myDwarf)
        {
            context.Dwarves.Add(myDwarf);
            context.SaveChanges();
        }

        public void UpdateDwarf()
        {
            context.SaveChanges();
        }

        public void DeleteDwarf(Dwarf myDwarf)
        {
            context.Dwarves.Remove(myDwarf);
            context.SaveChanges();
        }
        //Class Attributes
        public static int MAXAGE = 250;

        //data for randomization
        public static string[] MaleFirstNames = new string[] { "Gimli", "Thorin", "Thrain", "Thror", "Fili", "Kili", "Bifur", "Bofur", "Bombur", "Oin",
            "Gloin", "Balin", "Dwalin",  "Kraroud", "Darezil", "Gogheag", "Halgaem", "Yudgrour", "Whugnur"};
        public static string[] FemaleFirstNames = new string[] { "Jalmibo", "Umimrire", "Jakdrostr", "Lozuhilda", "Betgrehilda", "Debuna", "Skasoni", "Adgaren",
            "Bomnelyn", "Nakhibena", "Nedwealin", "Fobeabo", "Throghaelda"};
        public static string[] LastNames = new string[] { "Kegmaster", "Onyxmace", "Marbleblender", "Bitterchest", "Mithriltoe", "Grimbringer", "Frostmail",
            "Metalbow", "Kragbuster", "Blackarm", "Oakenshield", "Fieryflayer", "Emberspine" };
        public static string[] DwarfGroupOptions = new string[] {"Belegost Dwarf", "Erebor Dwarf", "Khazad-dum Dwarf", "Nogrod Dwarf", "Blue Mountain Dwarf",
        "Grey Mountain Dwarf", "Iron Hill Dwarf"};
        //constructors

        public Dwarf Generate(Random rand, int numberOfPhysical, int numberOfMental, int numberOfMagical = 0)
        {
            PersonLogic personLogic = new PersonLogic();
            //Person person =
            Dwarf dwarfPerson = (Dwarf)personLogic.Generate("dwarf", rand, new Dwarf());;
            
            dwarfPerson.RaceType = "dwarf";
            int index;
            //set name
            dwarfPerson.Name = GenerateName(dwarfPerson.Gender, rand);

            //reset age
            dwarfPerson.Age = rand.Next(1, MAXAGE);

            //reset position
            dwarfPerson.LengthOfRoleOccupancy = rand.Next(1, dwarfPerson.Age);

            //set DwarfFamily
            index = rand.Next(0, DwarfGroupOptions.Length);
            dwarfPerson.DwarfGroup = DwarfGroupOptions[index];

            AddDwarf(dwarfPerson);
            personLogic.GenerateAdventures(dwarfPerson.PersonID, rand.Next(1,10), rand);

            return dwarfPerson;
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
