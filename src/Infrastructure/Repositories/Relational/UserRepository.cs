using Domain.Entities.Relacional;
using Domain.Repositories;
using P2A.Leads.Domain.Specifications;
using System;

namespace Infrastructure.Repositories.Relational
{
    public class UserRepository : RelationalRepository<User>, IUsuarioRepository
    {
        public UserRepository()
        {
        }

        public User GetUserByLogin(UsuarioByEmailSpec spec)
        {
            if (spec == null)
                throw new ArgumentNullException(nameof(spec));

            return this.Get(spec);
        }
    }
}
