using Domain.Core;
using Domain.Entities.Relacional;
using System;
using System.Linq.Expressions;

namespace P2A.Leads.Domain.Specifications
{
    public class UsuarioByEmailSpec : BaseSpecification<User>
    {
        private string Login { get; set; }

        public UsuarioByEmailSpec(string login)
        {
            this.Login = login;
        }

        public override string Description => $"";

        protected override Expression<Func<User, bool>> GetFinalExpression() => x => x.Email == this.Login && x.Active == true;
    }
}
