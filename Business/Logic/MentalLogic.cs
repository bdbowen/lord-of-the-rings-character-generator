using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;

namespace CharacterGenerator
{
    public class MentalLogic
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud

        public Mental GetMental(int mentalID)
        {
            var mental = context.Mentals.Find(mentalID);
            return mental;
        }
        public IEnumerable<Mental> GetAllMentals()
        {
            var mentals = context.Mentals.ToList();
            return mentals;
        }
        public void AddMental(Mental myMental)
        {
            context.Mentals.Add(myMental);
            context.SaveChanges();
        }

        public void UpdateMental()
        {
            context.SaveChanges();
        }

        public void DeleteMental(Mental myMental)
        {
            context.Mentals.Remove(myMental);
            context.SaveChanges();
        }
    }

}
