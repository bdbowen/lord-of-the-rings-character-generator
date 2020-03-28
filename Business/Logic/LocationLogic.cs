using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;

namespace CharacterGenerator
{
    public class LocationLogic
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud
        public Location GetLocation(int locationID)
        {
            var location = context.Locations.Find(locationID);
            return location;
        }
        public IEnumerable<Location> GetAllLocations()
        {
            var locations = context.Locations.ToList();
            return locations;
        }
        public void AddLocation(Location myLocation)
        {
            context.Locations.Add(myLocation);
            context.SaveChanges();
        }

        public void UpdateLocation()
        {
            context.SaveChanges();
        }

        public void DeleteLocation(Location myLocation)
        {
            context.Locations.Remove(myLocation);
            context.SaveChanges();
        }

    }
}
