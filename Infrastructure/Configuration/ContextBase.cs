using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
	public class ContextBase : DbContext 
	{
		public ContextBase(DbContextOptions<ContextBase>options) : base(options)
		{
		}

		public DbSet<Produto> Produto { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
			    optionsBuilder.UseSqlServer(GetConnectionString());
				base.OnConfiguring(optionsBuilder);
			}
		}
		private string GetConnectionString()
		{
			string strCon = "Data Source=DESKTOP-FRAN\\SQLEXPRESS;Initial Catalog=DDD_ECOMMERC;Integrated Security=True";
			return strCon;
		}
	}
}
