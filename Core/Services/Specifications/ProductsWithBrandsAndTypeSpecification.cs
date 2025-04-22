using Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Specifications
{
	public class ProductsWithBrandsAndTypeSpecification:BaseSpecifications<Product, int>
	{
		public ProductsWithBrandsAndTypeSpecification():base(null)
		{
			AddInclude(P => P.Brand);
			AddInclude(P => P.Type);
		}

	}
}
