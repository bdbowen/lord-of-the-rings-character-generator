using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;

namespace CharacterGenerator
{
    public class AbilityLogic
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud
        public Ability GetAbility(int abilityID)
        {
            var ability = context.Abilities.Find(abilityID);
            return ability;
        }
        public IEnumerable<Ability> GetAllAbilities()
        {
            var abilities = context.Abilities.ToList();
            return abilities;
        }
        public void AddAbility(Ability myAbility)
        {
            context.Abilities.Add(myAbility);
            context.SaveChanges();
        }

        public void UpdateAbility()
        {
            context.SaveChanges();
        }

        public void DeleteAbility(Ability myAbility)
        {
            context.Abilities.Remove(myAbility);
            context.SaveChanges();
        }
    }
}