using Domain.Contracts;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
	public static class SpecificationEvaluator
	{
		public static IQueryable<TEntity> CreateQuery<TEntity,Tkey>(IQueryable<TEntity> InputQuery, ISpecification<TEntity, Tkey> Spec) where TEntity : ModelBase<Tkey>
		{
			var Query = InputQuery;

			if(Spec.Criteria != null)
			{
				Query = Query.Where(Spec.Criteria);
			}

			if(Spec.IncludeExpressions is not null && Spec.IncludeExpressions.Count > 0)
			{
				Query = Spec.IncludeExpressions.Aggregate(Query, (currentQuery, Exp) => currentQuery.Include(Exp));
			}

			return Query;
		}
	}
}
