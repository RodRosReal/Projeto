using Domain.Core;
using Domain.Dtos;
using Domain.Entities.Relacional;
using System;
using System.Linq.Expressions;

namespace P2A.Leads.Domain.Specifications
{
    public class UsersAllSpec : BaseSpecification<User>
    {
        private UserFilter Filter { get; set; }

        public UsersAllSpec(UserFilter filter)
        {
            this.Filter = filter;
        }

        public override string Description => $"";

        protected override Expression<Func<User, bool>> GetFinalExpression() => x =>
        (this.Filter.Id == 0 || x.Id == this.Filter.Id) &&
        (string.IsNullOrEmpty(this.Filter.NameLike) || x.Name.Contains(this.Filter.NameLike)) &&
        (string.IsNullOrEmpty(this.Filter.EmailLike) || x.Email.Contains(this.Filter.EmailLike) &&
        (!this.Filter.Active.HasValue || x.Active == this.Filter.Active.Value));
        }
}
