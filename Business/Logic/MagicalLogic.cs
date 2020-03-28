using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;
namespace CharacterGenerator
{
    public class MagicalLogic
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud

        public Magical GetMagical(int magicalID)
        {
            var magical = context.Magicals.Find(magicalID);
            return magical;
        }
        public IEnumerable<Magical> GetAllMagicals()
        {
            var magicals = context.Magicals.ToList();
            return magicals;
        }
        public void AddMagical(Magical myMagical)
        {
            context.Magicals.Add(myMagical);
            context.SaveChanges();
        }

        public void UpdateMagical()
        {
            context.SaveChanges();
        }

        public void DeleteMagical(Magical myMagical)
        {
            context.Magicals.Remove(myMagical);
            context.SaveChanges();
        }
    }
}
