using Domain.Core;
using Domain.Entities.Relacional;
using P2A.Leads.Domain.Specifications;

namespace Domain.Repositories
{
    public interface IUsuarioRepository : IRepository<User>
    {
        User GetUserByLogin(UsuarioByEmailSpec spec);
    }
}
