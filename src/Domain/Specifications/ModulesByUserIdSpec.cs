using Domain.Core;
using Domain.Entities.Relacional;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace P2A.Leads.Domain.Specifications
{
    public class ModulesByUserIdSpec : BaseSpecification<Module>
    {
        private int Id { get; set; }

        public ModulesByUserIdSpec(int id)
        {
            this.Id = id;
        }

        public override string Description => $"";

        protected override Expression<Func<Module, bool>> GetFinalExpression() => x => x.UserModule.Any(y=>y.IdUser == this.Id);
    }
}
