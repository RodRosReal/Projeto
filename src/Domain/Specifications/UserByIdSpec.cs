using Domain.Core;
using Domain.Entities.Relacional;
using System;
using System.Linq.Expressions;

namespace P2A.Leads.Domain.Specifications
{
    public class UserByIdSpec : BaseSpecification<User>
    {
        private int Id { get; set; }

        public UserByIdSpec(int id)
        {
            this.Id = id;
        }

        public override string Description => $"";

        protected override Expression<Func<User, bool>> GetFinalExpression() => x => x.Id == this.Id;
    }
}
