using Domain.Core;
using Domain.Dtos;
using Domain.Entities.Relacional;
using System;
using System.Linq.Expressions;

namespace P2A.Leads.Domain.Specifications
{
    public class ModulesAllSpec : BaseSpecification<Module>
    {
        private ModuleFilter Filter { get; set; }

        public ModulesAllSpec(ModuleFilter filter)
        {
            this.Filter = filter;
        }

        public override string Description => $"";

        protected override Expression<Func<Module, bool>> GetFinalExpression() => x =>
        (this.Filter.Id == 0 || x.Id == this.Filter.Id) &&
        (string.IsNullOrEmpty(this.Filter.Name) || x.Name.Contains(this.Filter.Name));
    }
}
