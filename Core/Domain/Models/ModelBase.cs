﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
	public class ModelBase<TKey>
	{
		public TKey Id { get; set; }
	}
}
