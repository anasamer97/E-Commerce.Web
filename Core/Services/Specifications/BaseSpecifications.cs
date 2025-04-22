using Domain.Contracts;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Specifications
{
	public abstract class BaseSpecifications<TEntity, TKey> : ISpecification<TEntity, TKey> where TEntity : ModelBase<TKey>
	{
		public BaseSpecifications(Expression<Func<TEntity, bool>>? PassedExpression)
		{
			Criteria = PassedExpression;
		}

		public Expression<Func<TEntity, bool>>? Criteria  {get; private set;}

		public List<Expression<Func<TEntity, object>>> IncludeExpressions { get; private set; } = new List<Expression<Func<TEntity, object>>>();

		protected void AddInclude(Expression<Func<TEntity, object>> includeExpression)
		{
			IncludeExpressions.Add(includeExpression);
		}
	}
}
