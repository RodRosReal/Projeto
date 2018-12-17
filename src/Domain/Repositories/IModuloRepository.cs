using Domain.Core;
using Domain.Entities.Relacional;
using P2A.Leads.Domain.Specifications;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IModuloRepository : IRepository<Module>
    {
        List<Module> GetModulosByUserId(ModulesByUserIdSpec spec);
    }
}
