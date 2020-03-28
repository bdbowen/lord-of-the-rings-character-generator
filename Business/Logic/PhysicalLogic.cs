using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;

namespace CharacterGenerator
{
    public class PhysicalLogic
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud

        public Physical GetPhysical(int physicalID)
        {
            var physical = context.Physicals.Find(physicalID);
            return physical;
        }
        public IEnumerable<Physical> GetAllPhysicals()
        {
            var physicals = context.Physicals.ToList();
            return physicals;
        }
        public void AddPhysical(Physical myPhysical)
        {
            context.Physicals.Add(myPhysical);
            context.SaveChanges();
        }

        public void UpdatePhysical()
        {
            context.SaveChanges();
        }

        public void DeletePhysical(Physical myPhysical)
        {
            context.Physicals.Remove(myPhysical);
            context.SaveChanges();
        }
    }

}
