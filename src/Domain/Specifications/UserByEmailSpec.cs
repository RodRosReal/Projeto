using Domain.Core;
using Domain.Entities.Relacional;
using System;
using System.Linq.Expressions;

namespace P2A.Leads.Domain.Specifications
{
    public class UserByEmailSpec : BaseSpecification<User>
    {
        private string Email { get; set; }

        public UserByEmailSpec(string email)
        {
            this.Email = email;
        }

        public override string Description => $"";

        protected override Expression<Func<User, bool>> GetFinalExpression() => x => x.Email == this.Email;
    }
}
