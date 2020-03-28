using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Domain;

namespace CharacterGenerator
{
    public class RoleLogic
    {
        private readonly CharacterGeneratorContext context = new CharacterGeneratorContext();
        //crud

        public Role GetRole(int roleID)
        {
            var role = context.Roles.Find(roleID);
            return role;
        }
        public IEnumerable<Role> GetAllRoles()
        {
            var roles = context.Roles.ToList();
            return roles;
        }
        public void AddRole(Role myRole)
        {
            context.Roles.Add(myRole);
            context.SaveChanges();
        }

        public void UpdateRole()
        {
            context.SaveChanges();
        }

        public void DeleteRole(Role myRole)
        {
            context.Roles.Remove(myRole);
            context.SaveChanges();
        }
    }

}
