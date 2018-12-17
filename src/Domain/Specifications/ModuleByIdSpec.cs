using Domain.Core;
using Domain.Entities.Relacional;
using System;
using System.Linq.Expressions;

namespace P2A.Leads.Domain.Specifications
{
    public class ModuleByIdSpec : BaseSpecification<Module>
    {
        private long Id { get; set; }

        public ModuleByIdSpec(long id)
        {
            this.Id = id;
        }

        public override string Description => $"";

        protected override Expression<Func<Module, bool>> GetFinalExpression() => x => x.Id == this.Id;
    }
}
