using Domain.Entities.Relacional;
using Domain.Repositories;
using P2A.Leads.Domain.Specifications;
using System.Collections.Generic;

namespace Infrastructure.Repositories.Relational
{
    public class ModuleRepository : RelationalRepository<Module>, IModuloRepository
    {
        public ModuleRepository()
        {
        }

        public List<Module> GetModulosByUserId(ModulesByUserIdSpec spec)
        {
            return this.Query(spec);
        }
    }
}
