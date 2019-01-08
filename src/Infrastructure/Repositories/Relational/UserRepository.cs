using Domain.Entities.Relacional;
using Domain.Repositories;
using P2A.Leads.Domain.Specifications;
using System;

namespace Infrastructure.Repositories.Relational
{
    public class UserRepository : RelationalRepository<User>, IUserRepository
    {
        public UserRepository()
        {
        }
    }
}
